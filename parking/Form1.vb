Imports System.IO
Imports System.IO.Ports
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form1
    Private WithEvents SerialPort1 As New SerialPort()
    Private _closingOrDisconnecting As Boolean

    Private _selectedFee As Decimal
    Private _durationSelected As Boolean

    Private ReadOnly _slotOccupied(6) As Boolean
    Private ReadOnly _slotEndTimeUtc(6) As DateTime
    Private ReadOnly _slotOvertimeChargedMinutes(6) As Integer
    Private _selectedDurationMinutes As Integer

    Private WithEvents _uiTimer As New Timer() With {.Interval = 1000}

    Private _btnRemoveCar1 As System.Windows.Forms.Button
    Private _btnRemoveCar2 As System.Windows.Forms.Button
    Private _btnRemoveCar3 As System.Windows.Forms.Button
    Private _btnRemoveCar4 As System.Windows.Forms.Button
    Private _btnRemoveCar5 As System.Windows.Forms.Button
    Private _btnRemoveCar6 As System.Windows.Forms.Button

    Dim parkingSlots(6) As Boolean ' Array to track parking slot availability
    Private Sub btnConnect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConnect.Click
        Try
            If SerialPort1.IsOpen Then
                _closingOrDisconnecting = True
                SerialPort1.Close()
                btnConnect.Text = "Connect"
                _closingOrDisconnecting = False
            Else
                SerialPort1.PortName = cmbSerialPort.Text
                SerialPort1.BaudRate = 9600
                SerialPort1.Open()
                btnConnect.Text = "Disconnect"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnScanPort_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnScanPort.Click
        cmbSerialPort.Items.Clear()
        For Each port As String In SerialPort.GetPortNames()
            cmbSerialPort.Items.Add(port)
        Next
    End Sub

    Private Sub ComboBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.Click
        ComboBox1.Items.Clear()
        For Each rate As String In {"9600", "19200", "38400", "57600", "115200"}
            ComboBox1.Items.Add(rate)
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnScanPort_Click(sender, e)
        If ComboBox1.Items.Count = 0 Then
            ComboBox1.Items.AddRange(New Object() {"9600", "19200", "38400", "57600", "115200"})
        End If
        ComboBox1.SelectedItem = "9600"

        ' Hide until Accept is clicked
        lblParkingDuration.Visible = False
        lblFee.Visible = False
        btnOneMin.Visible = False
        btnThreeMins.Visible = False
        btnFiveMins.Visible = False
        lblOneMin.Visible = False
        lblThreeMins.Visible = False
        lblFiveMins.Visible = False

        btnOneMin.Enabled = False
        btnThreeMins.Enabled = False
        btnFiveMins.Enabled = False

        btnAccept.Visible = False
        btnDecline.Visible = False
        btnAccept.Enabled = False
        btnDecline.Enabled = False

        displayCar1.Visible = False
        displayCar2.Visible = False
        displayCar3.Visible = False
        displayCar4.Visible = False
        displayCar5.Visible = False
        displayCar6.Visible = False

        btnAddCar1.Enabled = False
        btnAddCar2.Enabled = False
        btnAddCar3.Enabled = False
        btnAddCar4.Enabled = False
        btnAddCar5.Enabled = False
        btnAddCar6.Enabled = False

        If _btnRemoveCar1 IsNot Nothing Then _btnRemoveCar1.Enabled = False
        If _btnRemoveCar2 IsNot Nothing Then _btnRemoveCar2.Enabled = False
        If _btnRemoveCar3 IsNot Nothing Then _btnRemoveCar3.Enabled = False
        If _btnRemoveCar4 IsNot Nothing Then _btnRemoveCar4.Enabled = False
        If _btnRemoveCar5 IsNot Nothing Then _btnRemoveCar5.Enabled = False
        If _btnRemoveCar6 IsNot Nothing Then _btnRemoveCar6.Enabled = False

        _selectedFee = 0D
        _durationSelected = False
        _selectedDurationMinutes = 0

        CreateRemoveButtons()

        _uiTimer.Start()
    End Sub

    Private Sub CreateRemoveButtons()
        _btnRemoveCar1 = CreateRemoveButton(btnAddCar1, Sub() HandleRemoveCar(1))
        _btnRemoveCar2 = CreateRemoveButton(btnAddCar2, Sub() HandleRemoveCar(2))
        _btnRemoveCar3 = CreateRemoveButton(btnAddCar3, Sub() HandleRemoveCar(3))
        _btnRemoveCar4 = CreateRemoveButton(btnAddCar4, Sub() HandleRemoveCar(4))
        _btnRemoveCar5 = CreateRemoveButton(btnAddCar5, Sub() HandleRemoveCar(5))
        _btnRemoveCar6 = CreateRemoveButton(btnAddCar6, Sub() HandleRemoveCar(6))

        _btnRemoveCar1.Enabled = False
        _btnRemoveCar2.Enabled = False
        _btnRemoveCar3.Enabled = False
        _btnRemoveCar4.Enabled = False
        _btnRemoveCar5.Enabled = False
        _btnRemoveCar6.Enabled = False
    End Sub

    Private Function CreateRemoveButton(addButton As System.Windows.Forms.Button, onClick As Action) As System.Windows.Forms.Button
        Dim b As New System.Windows.Forms.Button() With {
            .Text = "Remove",
            .Font = addButton.Font,
            .BackColor = Color.Orange,
            .ForeColor = Color.Black,
            .Size = addButton.Size,
            .Location = New Point(addButton.Left, addButton.Top + addButton.Height + 4)
        }

        AddHandler b.Click, Sub(sender, e) onClick()
        Controls.Add(b)
        b.BringToFront()
        Return b
    End Function

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        If _closingOrDisconnecting Then Return

        Dim line As String = Nothing
        Try
            ' Read exactly once per DataReceived event.
            line = SerialPort1.ReadLine()
        Catch ex As IOException
            ' Common when disconnecting/closing while a read is blocked.
            Return
        Catch ex As InvalidOperationException
            ' Port closed.
            Return
        End Try

        Dim data As String = line.Trim()

        BeginInvoke(Sub()
                        AppendToLog(line)
                        If data = "TRUE" Then
                            lblMotionDetector.Text = "CAR WAITING"
                            btnAccept.Visible = True
                            btnDecline.Visible = True
                            btnAccept.Enabled = True
                            btnDecline.Enabled = True
                            _selectedFee = 0D
                            _durationSelected = False
                        ElseIf data = "FALSE" Then
                            lblMotionDetector.Text = "NO CAR WAITING"
                            btnAccept.Visible = False
                            btnDecline.Visible = False

                            btnAddCar1.Enabled = False
                            btnAddCar2.Enabled = False
                            btnAddCar3.Enabled = False
                            btnAddCar4.Enabled = False
                            btnAddCar5.Enabled = False
                            btnAddCar6.Enabled = False

                            lblParkingDuration.Visible = False
                            lblFee.Visible = False
                            btnOneMin.Visible = False
                            btnThreeMins.Visible = False
                            btnFiveMins.Visible = False
                            lblOneMin.Visible = False
                            lblThreeMins.Visible = False
                            lblFiveMins.Visible = False

                            btnOneMin.Enabled = False
                            btnThreeMins.Enabled = False
                            btnFiveMins.Enabled = False

                            _selectedFee = 0D
                            _durationSelected = False
                        End If
                    End Sub)
    End Sub

    Private Sub AppendToLog(ByVal line As String)
        RichTextBox1.AppendText(line & vbCrLf)
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        lblParkingDuration.Visible = True
        lblFee.Visible = True
        btnOneMin.Visible = True
        btnThreeMins.Visible = True
        btnFiveMins.Visible = True
        lblOneMin.Visible = True
        lblThreeMins.Visible = True
        lblFiveMins.Visible = True

        btnOneMin.Enabled = True
        btnThreeMins.Enabled = True
        btnFiveMins.Enabled = True

        _selectedFee = 0D
        _durationSelected = False
    End Sub

    Private Sub btnDecline_Click(sender As Object, e As EventArgs) Handles btnDecline.Click
        Try
            If SerialPort1.IsOpen Then
                SerialPort1.WriteLine("DECLINE" & vbLf)
            End If
        Catch
        End Try

        lblMotionDetector.Text = "NO CAR WAITING"
        btnAccept.Visible = False
        btnDecline.Visible = False

        btnAddCar1.Enabled = False
        btnAddCar2.Enabled = False
        btnAddCar3.Enabled = False
        btnAddCar4.Enabled = False
        btnAddCar5.Enabled = False
        btnAddCar6.Enabled = False

        lblParkingDuration.Visible = False
        lblFee.Visible = False
        btnOneMin.Visible = False
        btnThreeMins.Visible = False
        btnFiveMins.Visible = False
        lblOneMin.Visible = False
        lblThreeMins.Visible = False
        lblFiveMins.Visible = False

        btnOneMin.Enabled = False
        btnThreeMins.Enabled = False
        btnFiveMins.Enabled = False

        _selectedFee = 0D
        _durationSelected = False
    End Sub

    Private Sub SelectDurationAndEnableParking(fee As Decimal)
        _selectedFee = fee
        _durationSelected = True

        If fee = 50D Then
            _selectedDurationMinutes = 1
        ElseIf fee = 75D Then
            _selectedDurationMinutes = 3
        ElseIf fee = 100D Then
            _selectedDurationMinutes = 5
        Else
            _selectedDurationMinutes = 0
        End If

        Dim currentIncome As Decimal
        Decimal.TryParse(lblTotalIncome.Text, currentIncome)
        currentIncome += fee
        lblTotalIncome.Text = currentIncome.ToString("0.00")

        btnAddCar1.Enabled = True
        btnAddCar2.Enabled = True
        btnAddCar3.Enabled = True
        btnAddCar4.Enabled = True
        btnAddCar5.Enabled = True
        btnAddCar6.Enabled = True

        btnOneMin.Enabled = False
        btnThreeMins.Enabled = False
        btnFiveMins.Enabled = False
    End Sub

    Private Sub btnOneMin_Click(sender As Object, e As EventArgs) Handles btnOneMin.Click
        SelectDurationAndEnableParking(50D)
    End Sub

    Private Sub btnThreeMins_Click(sender As Object, e As EventArgs) Handles btnThreeMins.Click
        SelectDurationAndEnableParking(75D)
    End Sub

    Private Sub btnFiveMins_Click(sender As Object, e As EventArgs) Handles btnFiveMins.Click
        SelectDurationAndEnableParking(100D)
    End Sub

    Private Sub HandleAddCar(slotIndex As Integer)
        If Not _durationSelected Then Return
        If _selectedDurationMinutes <= 0 Then Return
        If _slotOccupied(slotIndex) Then Return

        _slotOccupied(slotIndex) = True
        _slotEndTimeUtc(slotIndex) = DateTime.UtcNow.AddMinutes(_selectedDurationMinutes)
        _slotOvertimeChargedMinutes(slotIndex) = 0

        Select Case slotIndex
            Case 1
                displayCar1.Visible = True
                btnAddCar1.Enabled = False
                _btnRemoveCar1.Enabled = True
            Case 2
                displayCar2.Visible = True
                btnAddCar2.Enabled = False
                _btnRemoveCar2.Enabled = True
            Case 3
                displayCar3.Visible = True
                btnAddCar3.Enabled = False
                _btnRemoveCar3.Enabled = True
            Case 4
                displayCar4.Visible = True
                btnAddCar4.Enabled = False
                _btnRemoveCar4.Enabled = True
            Case 5
                displayCar5.Visible = True
                btnAddCar5.Enabled = False
                _btnRemoveCar5.Enabled = True
            Case 6
                displayCar6.Visible = True
                btnAddCar6.Enabled = False
                _btnRemoveCar6.Enabled = True
        End Select

        btnAddCar1.Enabled = False
        btnAddCar2.Enabled = False
        btnAddCar3.Enabled = False
        btnAddCar4.Enabled = False
        btnAddCar5.Enabled = False
        btnAddCar6.Enabled = False

        Try
            If SerialPort1.IsOpen Then
                SerialPort1.WriteLine("ACCEPT" & vbLf)
            End If
        Catch
        End Try

        UpdateFullSlotSignal()
    End Sub

    Private Sub HandleRemoveCar(slotIndex As Integer)
        If Not _slotOccupied(slotIndex) Then Return

        Try
            If SerialPort1.IsOpen Then
                SerialPort1.WriteLine("EXIT" & vbLf)
            End If
        Catch
        End Try

        _slotOccupied(slotIndex) = False
        _slotEndTimeUtc(slotIndex) = DateTime.MinValue
        _slotOvertimeChargedMinutes(slotIndex) = 0

        Select Case slotIndex
            Case 1
                displayCar1.Visible = False
                btnAddCar1.Enabled = _durationSelected
                _btnRemoveCar1.Enabled = False
            Case 2
                displayCar2.Visible = False
                btnAddCar2.Enabled = _durationSelected
                _btnRemoveCar2.Enabled = False
            Case 3
                displayCar3.Visible = False
                btnAddCar3.Enabled = _durationSelected
                _btnRemoveCar3.Enabled = False
            Case 4
                displayCar4.Visible = False
                btnAddCar4.Enabled = _durationSelected
                _btnRemoveCar4.Enabled = False
            Case 5
                displayCar5.Visible = False
                btnAddCar5.Enabled = _durationSelected
                _btnRemoveCar5.Enabled = False
            Case 6
                displayCar6.Visible = False
                btnAddCar6.Enabled = _durationSelected
                _btnRemoveCar6.Enabled = False
        End Select

        Dim targetPanel As Panel = Nothing
        Select Case slotIndex
            Case 1 : targetPanel = displayCar1
            Case 2 : targetPanel = displayCar2
            Case 3 : targetPanel = displayCar3
            Case 4 : targetPanel = displayCar4
            Case 5 : targetPanel = displayCar5
            Case 6 : targetPanel = displayCar6
        End Select

        If targetPanel IsNot Nothing Then
            Dim timerLabel As Label = TryCast(targetPanel.Tag, Label)
            If timerLabel IsNot Nothing Then
                targetPanel.Controls.Remove(timerLabel)
                timerLabel.Dispose()
                targetPanel.Tag = Nothing
            End If
        End If

        UpdateFullSlotSignal()
    End Sub

    Private Sub UpdateFullSlotSignal()
        Dim occupiedCount As Integer = 0
        For i As Integer = 1 To 6
            If _slotOccupied(i) Then occupiedCount += 1
        Next

        Dim command As String = If(occupiedCount >= 6, "FULL SLOT", "VACANT")
        Try
            If SerialPort1.IsOpen Then
                SerialPort1.WriteLine(command & vbLf)
            End If
        Catch
        End Try
    End Sub

    Private Sub _uiTimer_Tick(sender As Object, e As EventArgs) Handles _uiTimer.Tick
        For i As Integer = 1 To 6
            If Not _slotOccupied(i) Then Continue For

            Dim remaining As TimeSpan = _slotEndTimeUtc(i) - DateTime.UtcNow
            Dim overtime As TimeSpan = TimeSpan.Zero

            If remaining < TimeSpan.Zero Then
                overtime = -remaining
                remaining = TimeSpan.Zero

                Dim minutesToCharge As Integer = CInt(Math.Ceiling(overtime.TotalMinutes))
                If minutesToCharge > _slotOvertimeChargedMinutes(i) Then
                    Dim additionalMinutes As Integer = minutesToCharge - _slotOvertimeChargedMinutes(i)
                    _slotOvertimeChargedMinutes(i) = minutesToCharge

                    Dim currentIncome As Decimal
                    Decimal.TryParse(lblTotalIncome.Text, currentIncome)
                    currentIncome += additionalMinutes * 50D
                    lblTotalIncome.Text = currentIncome.ToString("0.00")
                End If
            End If

            Dim timerText As String
            If overtime > TimeSpan.Zero Then
                timerText = $"+{overtime.Minutes:00}:{overtime.Seconds:00}"
            Else
                timerText = $"{CInt(remaining.TotalMinutes):00}:{remaining.Seconds:00}"
            End If

            Dim targetPanel As Panel = Nothing
            Select Case i
                Case 1 : targetPanel = displayCar1
                Case 2 : targetPanel = displayCar2
                Case 3 : targetPanel = displayCar3
                Case 4 : targetPanel = displayCar4
                Case 5 : targetPanel = displayCar5
                Case 6 : targetPanel = displayCar6
            End Select

            If targetPanel Is Nothing Then Continue For

            Dim timerLabel As Label = TryCast(targetPanel.Tag, Label)
            If timerLabel Is Nothing Then
                timerLabel = New Label() With {
                    .AutoSize = True,
                    .BackColor = Color.Transparent,
                    .Font = New Font("Segoe UI", 12.0F, FontStyle.Bold),
                    .Location = New Point(5, 5)
                }
                targetPanel.Controls.Add(timerLabel)
                targetPanel.Tag = timerLabel
            End If

            timerLabel.Text = timerText
            timerLabel.ForeColor = If(overtime > TimeSpan.Zero, Color.Red, Color.Blue)
        Next
    End Sub

    Private Sub btnAddCar1_Click(sender As Object, e As EventArgs) Handles btnAddCar1.Click
        HandleAddCar(1)
    End Sub

    Private Sub btnAddCar2_Click(sender As Object, e As EventArgs) Handles btnAddCar2.Click
        HandleAddCar(2)
    End Sub

    Private Sub btnAddCar3_Click(sender As Object, e As EventArgs) Handles btnAddCar3.Click
        HandleAddCar(3)
    End Sub

    Private Sub btnAddCar4_Click(sender As Object, e As EventArgs) Handles btnAddCar4.Click
        HandleAddCar(4)
    End Sub

    Private Sub btnAddCar5_Click(sender As Object, e As EventArgs) Handles btnAddCar5.Click
        HandleAddCar(5)
    End Sub

    Private Sub btnAddCar6_Click(sender As Object, e As EventArgs) Handles btnAddCar6.Click
        HandleAddCar(6)
    End Sub

    ' NOTE: Do not add a second SerialPort1.DataReceived handler that reads from the port.
    ' Multiple handlers calling ReadLine() will race/consume data and can surface as aborted I/O.

End Class
