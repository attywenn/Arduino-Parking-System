<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        headerLabel = New Label()
        btnScanPort = New Button()
        cmbSerialPort = New ComboBox()
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        btnConnect = New Button()
        lblReceived = New Label()
        RichTextBox1 = New RichTextBox()
        VScrollBar1 = New VScrollBar()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        displayCar1 = New Panel()
        displayCar2 = New Panel()
        Label2 = New Label()
        Label3 = New Label()
        lblMotionDetector = New Label()
        btnAccept = New Button()
        btnDecline = New Button()
        displayCar3 = New Panel()
        displayCar4 = New Panel()
        displayCar5 = New Panel()
        displayCar6 = New Panel()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        btnAddCar2 = New Button()
        btnAddCar1 = New Button()
        btnAddCar3 = New Button()
        btnAddCar5 = New Button()
        btnAddCar4 = New Button()
        btnAddCar6 = New Button()
        lblParkingDuration = New Label()
        btnOneMin = New Button()
        btnThreeMins = New Button()
        btnFiveMins = New Button()
        lblFee = New Label()
        lblOneMin = New Label()
        lblThreeMins = New Label()
        lblFiveMins = New Label()
        lblIncomeLabel = New Label()
        Panel14 = New Panel()
        lblTotalIncome = New Label()
        lblCurrency = New Label()
        Panel14.SuspendLayout()
        SuspendLayout()
        ' 
        ' headerLabel
        ' 
        headerLabel.AutoSize = True
        headerLabel.FlatStyle = FlatStyle.Popup
        headerLabel.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        headerLabel.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        headerLabel.Location = New Point(120, 30)
        headerLabel.Name = "headerLabel"
        headerLabel.Size = New Size(421, 44)
        headerLabel.TabIndex = 0
        headerLabel.Text = "Boni's Parking System"
        ' 
        ' btnScanPort
        ' 
        btnScanPort.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnScanPort.Cursor = Cursors.Hand
        btnScanPort.FlatStyle = FlatStyle.System
        btnScanPort.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnScanPort.Location = New Point(57, 141)
        btnScanPort.Name = "btnScanPort"
        btnScanPort.Size = New Size(163, 47)
        btnScanPort.TabIndex = 1
        btnScanPort.Text = "Scan Port"
        btnScanPort.UseVisualStyleBackColor = False
        ' 
        ' cmbSerialPort
        ' 
        cmbSerialPort.FormattingEnabled = True
        cmbSerialPort.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4"})
        cmbSerialPort.Location = New Point(226, 152)
        cmbSerialPort.Name = "cmbSerialPort"
        cmbSerialPort.Size = New Size(163, 23)
        cmbSerialPort.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.System
        Button1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(57, 212)
        Button1.Name = "Button1"
        Button1.Size = New Size(163, 47)
        Button1.TabIndex = 3
        Button1.Text = "Baud Rate"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4"})
        ComboBox1.Location = New Point(226, 223)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(163, 23)
        ComboBox1.TabIndex = 4
        ' 
        ' btnConnect
        ' 
        btnConnect.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnConnect.Cursor = Cursors.Hand
        btnConnect.FlatStyle = FlatStyle.System
        btnConnect.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConnect.Location = New Point(163, 274)
        btnConnect.Name = "btnConnect"
        btnConnect.Size = New Size(163, 47)
        btnConnect.TabIndex = 5
        btnConnect.Text = "Connect"
        btnConnect.UseVisualStyleBackColor = False
        ' 
        ' lblReceived
        ' 
        lblReceived.AutoSize = True
        lblReceived.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblReceived.Location = New Point(59, 351)
        lblReceived.Name = "lblReceived"
        lblReceived.Size = New Size(161, 20)
        lblReceived.TabIndex = 8
        lblReceived.Text = "Parking Activity Logs:"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(57, 373)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(341, 303)
        RichTextBox1.TabIndex = 9
        RichTextBox1.Text = ""
        ' 
        ' VScrollBar1
        ' 
        VScrollBar1.Location = New Point(380, 445)
        VScrollBar1.Name = "VScrollBar1"
        VScrollBar1.Size = New Size(18, 231)
        VScrollBar1.TabIndex = 10
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackgroundImage = CType(resources.GetObject("FlowLayoutPanel1.BackgroundImage"), Image)
        FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
        FlowLayoutPanel1.Location = New Point(5, 5)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(109, 100)
        FlowLayoutPanel1.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(489, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(311, 37)
        Label1.TabIndex = 13
        Label1.Text = "Available Parking Slots"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Location = New Point(633, 173)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(31, 504)
        Panel1.TabIndex = 14
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Location = New Point(407, 173)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(476, 32)
        Panel2.TabIndex = 15
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Panel3.Location = New Point(407, 328)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(476, 32)
        Panel3.TabIndex = 16
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Panel4.Location = New Point(407, 488)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(476, 32)
        Panel4.TabIndex = 16
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Black
        Panel5.Location = New Point(407, 645)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(476, 32)
        Panel5.TabIndex = 16
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), Image)
        Panel6.Location = New Point(407, 173)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(15, 504)
        Panel6.TabIndex = 15
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.BackgroundImage = CType(resources.GetObject("Panel7.BackgroundImage"), Image)
        Panel7.Location = New Point(868, 173)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(15, 504)
        Panel7.TabIndex = 16
        ' 
        ' displayCar1
        ' 
        displayCar1.BackgroundImage = CType(resources.GetObject("displayCar1.BackgroundImage"), Image)
        displayCar1.BackgroundImageLayout = ImageLayout.Stretch
        displayCar1.Location = New Point(476, 222)
        displayCar1.Name = "displayCar1"
        displayCar1.Size = New Size(101, 64)
        displayCar1.TabIndex = 17
        ' 
        ' displayCar2
        ' 
        displayCar2.BackgroundImage = CType(resources.GetObject("displayCar2.BackgroundImage"), Image)
        displayCar2.BackgroundImageLayout = ImageLayout.Stretch
        displayCar2.Location = New Point(718, 222)
        displayCar2.Name = "displayCar2"
        displayCar2.Size = New Size(101, 64)
        displayCar2.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(976, 199)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 20)
        Label2.TabIndex = 20
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(889, 173)
        Label3.Name = "Label3"
        Label3.Size = New Size(171, 32)
        Label3.TabIndex = 21
        Label3.Text = "GATE STATUS:"
        ' 
        ' lblMotionDetector
        ' 
        lblMotionDetector.AutoSize = True
        lblMotionDetector.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMotionDetector.Location = New Point(964, 234)
        lblMotionDetector.Name = "lblMotionDetector"
        lblMotionDetector.Size = New Size(0, 25)
        lblMotionDetector.TabIndex = 22
        ' 
        ' btnAccept
        ' 
        btnAccept.BackColor = Color.Lime
        btnAccept.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAccept.ForeColor = Color.Black
        btnAccept.Location = New Point(913, 286)
        btnAccept.Name = "btnAccept"
        btnAccept.Size = New Size(127, 37)
        btnAccept.TabIndex = 23
        btnAccept.Text = "Accept"
        btnAccept.UseVisualStyleBackColor = False
        ' 
        ' btnDecline
        ' 
        btnDecline.BackColor = Color.Red
        btnDecline.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDecline.Location = New Point(1046, 286)
        btnDecline.Name = "btnDecline"
        btnDecline.Size = New Size(126, 37)
        btnDecline.TabIndex = 24
        btnDecline.Text = "Decline"
        btnDecline.UseVisualStyleBackColor = False
        ' 
        ' displayCar3
        ' 
        displayCar3.BackgroundImage = CType(resources.GetObject("displayCar3.BackgroundImage"), Image)
        displayCar3.BackgroundImageLayout = ImageLayout.Stretch
        displayCar3.Location = New Point(476, 378)
        displayCar3.Name = "displayCar3"
        displayCar3.Size = New Size(101, 64)
        displayCar3.TabIndex = 25
        ' 
        ' displayCar4
        ' 
        displayCar4.BackgroundImage = CType(resources.GetObject("displayCar4.BackgroundImage"), Image)
        displayCar4.BackgroundImageLayout = ImageLayout.Stretch
        displayCar4.Location = New Point(718, 378)
        displayCar4.Name = "displayCar4"
        displayCar4.Size = New Size(101, 64)
        displayCar4.TabIndex = 26
        ' 
        ' displayCar5
        ' 
        displayCar5.BackgroundImage = CType(resources.GetObject("displayCar5.BackgroundImage"), Image)
        displayCar5.BackgroundImageLayout = ImageLayout.Stretch
        displayCar5.Location = New Point(476, 539)
        displayCar5.Name = "displayCar5"
        displayCar5.Size = New Size(101, 64)
        displayCar5.TabIndex = 26
        ' 
        ' displayCar6
        ' 
        displayCar6.BackgroundImage = CType(resources.GetObject("displayCar6.BackgroundImage"), Image)
        displayCar6.BackgroundImageLayout = ImageLayout.Stretch
        displayCar6.Location = New Point(718, 539)
        displayCar6.Name = "displayCar6"
        displayCar6.Size = New Size(101, 64)
        displayCar6.TabIndex = 26
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(428, 212)
        Label4.Name = "Label4"
        Label4.Size = New Size(23, 25)
        Label4.TabIndex = 27
        Label4.Text = "1"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(670, 212)
        Label5.Name = "Label5"
        Label5.Size = New Size(23, 25)
        Label5.TabIndex = 28
        Label5.Text = "2"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(428, 363)
        Label6.Name = "Label6"
        Label6.Size = New Size(23, 25)
        Label6.TabIndex = 29
        Label6.Text = "3"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(670, 363)
        Label7.Name = "Label7"
        Label7.Size = New Size(23, 25)
        Label7.TabIndex = 30
        Label7.Text = "4"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(428, 523)
        Label8.Name = "Label8"
        Label8.Size = New Size(23, 25)
        Label8.TabIndex = 31
        Label8.Text = "5"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(670, 523)
        Label9.Name = "Label9"
        Label9.Size = New Size(23, 25)
        Label9.TabIndex = 32
        Label9.Text = "6"
        ' 
        ' btnAddCar2
        ' 
        btnAddCar2.BackColor = Color.Lime
        btnAddCar2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddCar2.ForeColor = Color.Black
        btnAddCar2.Location = New Point(670, 294)
        btnAddCar2.Name = "btnAddCar2"
        btnAddCar2.Size = New Size(92, 29)
        btnAddCar2.TabIndex = 33
        btnAddCar2.Text = "Add"
        btnAddCar2.UseVisualStyleBackColor = False
        ' 
        ' btnAddCar1
        ' 
        btnAddCar1.BackColor = Color.Lime
        btnAddCar1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddCar1.ForeColor = Color.Black
        btnAddCar1.Location = New Point(437, 294)
        btnAddCar1.Name = "btnAddCar1"
        btnAddCar1.Size = New Size(92, 29)
        btnAddCar1.TabIndex = 35
        btnAddCar1.Text = "Add"
        btnAddCar1.UseVisualStyleBackColor = False
        ' 
        ' btnAddCar3
        ' 
        btnAddCar3.BackColor = Color.Lime
        btnAddCar3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddCar3.ForeColor = Color.Black
        btnAddCar3.Location = New Point(437, 453)
        btnAddCar3.Name = "btnAddCar3"
        btnAddCar3.Size = New Size(92, 29)
        btnAddCar3.TabIndex = 37
        btnAddCar3.Text = "Add"
        btnAddCar3.UseVisualStyleBackColor = False
        ' 
        ' btnAddCar5
        ' 
        btnAddCar5.BackColor = Color.Lime
        btnAddCar5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddCar5.ForeColor = Color.Black
        btnAddCar5.Location = New Point(437, 609)
        btnAddCar5.Name = "btnAddCar5"
        btnAddCar5.Size = New Size(92, 29)
        btnAddCar5.TabIndex = 39
        btnAddCar5.Text = "Add"
        btnAddCar5.UseVisualStyleBackColor = False
        ' 
        ' btnAddCar4
        ' 
        btnAddCar4.BackColor = Color.Lime
        btnAddCar4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddCar4.ForeColor = Color.Black
        btnAddCar4.Location = New Point(672, 453)
        btnAddCar4.Name = "btnAddCar4"
        btnAddCar4.Size = New Size(92, 29)
        btnAddCar4.TabIndex = 41
        btnAddCar4.Text = "Add"
        btnAddCar4.UseVisualStyleBackColor = False
        ' 
        ' btnAddCar6
        ' 
        btnAddCar6.BackColor = Color.Lime
        btnAddCar6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddCar6.ForeColor = Color.Black
        btnAddCar6.Location = New Point(670, 609)
        btnAddCar6.Name = "btnAddCar6"
        btnAddCar6.Size = New Size(92, 29)
        btnAddCar6.TabIndex = 43
        btnAddCar6.Text = "Add"
        btnAddCar6.UseVisualStyleBackColor = False
        ' 
        ' lblParkingDuration
        ' 
        lblParkingDuration.AutoSize = True
        lblParkingDuration.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblParkingDuration.ForeColor = Color.Blue
        lblParkingDuration.Location = New Point(919, 350)
        lblParkingDuration.Name = "lblParkingDuration"
        lblParkingDuration.Size = New Size(141, 21)
        lblParkingDuration.TabIndex = 45
        lblParkingDuration.Text = "Parking Duration"
        ' 
        ' btnOneMin
        ' 
        btnOneMin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOneMin.Location = New Point(932, 378)
        btnOneMin.Name = "btnOneMin"
        btnOneMin.Size = New Size(108, 33)
        btnOneMin.TabIndex = 46
        btnOneMin.Text = "1 Minute"
        btnOneMin.UseVisualStyleBackColor = True
        ' 
        ' btnThreeMins
        ' 
        btnThreeMins.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnThreeMins.Location = New Point(932, 417)
        btnThreeMins.Name = "btnThreeMins"
        btnThreeMins.Size = New Size(108, 33)
        btnThreeMins.TabIndex = 47
        btnThreeMins.Text = "3 Minutes"
        btnThreeMins.UseVisualStyleBackColor = True
        ' 
        ' btnFiveMins
        ' 
        btnFiveMins.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFiveMins.Location = New Point(932, 456)
        btnFiveMins.Name = "btnFiveMins"
        btnFiveMins.Size = New Size(108, 33)
        btnFiveMins.TabIndex = 48
        btnFiveMins.Text = "5 Minutes"
        btnFiveMins.UseVisualStyleBackColor = True
        ' 
        ' lblFee
        ' 
        lblFee.AutoSize = True
        lblFee.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFee.ForeColor = Color.Blue
        lblFee.Location = New Point(1122, 350)
        lblFee.Name = "lblFee"
        lblFee.Size = New Size(36, 21)
        lblFee.TabIndex = 49
        lblFee.Text = "Fee"
        ' 
        ' lblOneMin
        ' 
        lblOneMin.AutoSize = True
        lblOneMin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOneMin.Location = New Point(1108, 384)
        lblOneMin.Name = "lblOneMin"
        lblOneMin.Size = New Size(64, 21)
        lblOneMin.TabIndex = 50
        lblOneMin.Text = "50 PHP"
        ' 
        ' lblThreeMins
        ' 
        lblThreeMins.AutoSize = True
        lblThreeMins.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblThreeMins.Location = New Point(1108, 423)
        lblThreeMins.Name = "lblThreeMins"
        lblThreeMins.Size = New Size(64, 21)
        lblThreeMins.TabIndex = 51
        lblThreeMins.Text = "75 PHP"
        ' 
        ' lblFiveMins
        ' 
        lblFiveMins.AutoSize = True
        lblFiveMins.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFiveMins.Location = New Point(1099, 461)
        lblFiveMins.Name = "lblFiveMins"
        lblFiveMins.Size = New Size(73, 21)
        lblFiveMins.TabIndex = 52
        lblFiveMins.Text = "100 PHP"
        ' 
        ' lblIncomeLabel
        ' 
        lblIncomeLabel.AutoSize = True
        lblIncomeLabel.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIncomeLabel.Location = New Point(919, 539)
        lblIncomeLabel.Name = "lblIncomeLabel"
        lblIncomeLabel.Size = New Size(143, 30)
        lblIncomeLabel.TabIndex = 53
        lblIncomeLabel.Text = "NET INCOME"
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = Color.WhiteSmoke
        Panel14.Controls.Add(lblTotalIncome)
        Panel14.Controls.Add(lblCurrency)
        Panel14.Location = New Point(943, 573)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(229, 65)
        Panel14.TabIndex = 54
        ' 
        ' lblTotalIncome
        ' 
        lblTotalIncome.AutoSize = True
        lblTotalIncome.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalIncome.ForeColor = Color.Green
        lblTotalIncome.Location = New Point(132, 7)
        lblTotalIncome.Name = "lblTotalIncome"
        lblTotalIncome.Size = New Size(83, 45)
        lblTotalIncome.TabIndex = 1
        lblTotalIncome.Text = "0.00"
        ' 
        ' lblCurrency
        ' 
        lblCurrency.AutoSize = True
        lblCurrency.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCurrency.ForeColor = Color.Green
        lblCurrency.Location = New Point(3, 17)
        lblCurrency.Name = "lblCurrency"
        lblCurrency.Size = New Size(62, 32)
        lblCurrency.TabIndex = 0
        lblCurrency.Text = "PHP"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(1264, 681)
        Controls.Add(Panel14)
        Controls.Add(lblIncomeLabel)
        Controls.Add(lblFiveMins)
        Controls.Add(lblThreeMins)
        Controls.Add(lblOneMin)
        Controls.Add(lblFee)
        Controls.Add(btnFiveMins)
        Controls.Add(btnThreeMins)
        Controls.Add(btnOneMin)
        Controls.Add(lblParkingDuration)
        Controls.Add(btnAddCar6)
        Controls.Add(btnAddCar4)
        Controls.Add(btnAddCar5)
        Controls.Add(btnAddCar3)
        Controls.Add(btnAddCar1)
        Controls.Add(btnAddCar2)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(displayCar6)
        Controls.Add(displayCar5)
        Controls.Add(displayCar4)
        Controls.Add(displayCar3)
        Controls.Add(btnDecline)
        Controls.Add(btnAccept)
        Controls.Add(lblMotionDetector)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(displayCar2)
        Controls.Add(displayCar1)
        Controls.Add(Panel7)
        Controls.Add(Panel1)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Label1)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(VScrollBar1)
        Controls.Add(lblReceived)
        Controls.Add(RichTextBox1)
        Controls.Add(btnConnect)
        Controls.Add(ComboBox1)
        Controls.Add(Button1)
        Controls.Add(cmbSerialPort)
        Controls.Add(btnScanPort)
        Controls.Add(headerLabel)
        MaximumSize = New Size(1280, 720)
        MinimumSize = New Size(1280, 720)
        Name = "Form1"
        Padding = New Padding(2)
        RightToLeftLayout = True
        Text = "Boni's Parking System"
        Panel14.ResumeLayout(False)
        Panel14.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents headerLabel As Label
    Friend WithEvents btnScanPort As Button
    Friend WithEvents cmbSerialPort As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents lblReceived As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents displayCar1 As Panel
    Friend WithEvents displayCar2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMotionDetector As Label
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnDecline As Button
    Friend WithEvents displayCar3 As Panel
    Friend WithEvents displayCar4 As Panel
    Friend WithEvents displayCar5 As Panel
    Friend WithEvents displayCar6 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAddCar2 As Button
    Friend WithEvents btnAddCar1 As Button
    Friend WithEvents btnAddCar3 As Button
    Friend WithEvents btnAddCar5 As Button
    Friend WithEvents btnAddCar4 As Button
    Friend WithEvents btnAddCar6 As Button
    Friend WithEvents lblParkingDuration As Label
    Friend WithEvents btnOneMin As Button
    Friend WithEvents btnThreeMins As Button
    Friend WithEvents btnFiveMins As Button
    Friend WithEvents lblFee As Label
    Friend WithEvents lblOneMin As Label
    Friend WithEvents lblThreeMins As Label
    Friend WithEvents lblFiveMins As Label
    Friend WithEvents lblIncomeLabel As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents lblTotalIncome As Label
    Friend WithEvents lblCurrency As Label

End Class
