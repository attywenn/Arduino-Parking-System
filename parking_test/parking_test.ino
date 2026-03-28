#include <Servo.h>
#include <Wire.h>
#include <LiquidCrystal_I2C.h>

#define TRIG_PIN 8
#define SERVO 9
#define ECHO_PIN 10
#define RED 4
#define GREEN 5

LiquidCrystal_I2C lcd(0x27, 16, 2);
Servo gateServo;

bool motionDetected;
bool lastState = false;
bool waitingDecision = false;

void setup() {
  Serial.begin(9600);
  lcd.init();
  lcd.backlight();

  gateServo.attach(SERVO);
  pinMode(TRIG_PIN, OUTPUT);
  pinMode(ECHO_PIN, INPUT);
  pinMode(7, OUTPUT);
  pinMode(RED, OUTPUT);
  pinMode(GREEN, OUTPUT);

  lcd.setCursor(0,0);
  lcd.print("Boni's         ");
  lcd.setCursor(0,1);
  lcd.print("Parking lot    ");
}

void loop() {
  long duration;
  float distance;

  // ultrasonic
  digitalWrite(TRIG_PIN, LOW);
  delayMicroseconds(2);
  digitalWrite(TRIG_PIN, HIGH);
  delayMicroseconds(10);
  digitalWrite(TRIG_PIN, LOW);

  duration = pulseIn(ECHO_PIN, HIGH);
  distance = duration * 0.034 / 2;

  // detect
  if (distance < 15) {
    motionDetected = true;
    waitingDecision = true;
    digitalWrite(7, HIGH);
    digitalWrite(GREEN, LOW);
    digitalWrite(RED, HIGH);
  } 
  else {
    motionDetected = false;
    waitingDecision = false;
    digitalWrite(7, LOW);
    gateServo.write(0);
    digitalWrite(GREEN, LOW);
    digitalWrite(RED, HIGH);
  }

  // 🔥 SEND ONLY WHEN CHANGED (IMPORTANT)
  if (motionDetected != lastState) {
    Serial.println(motionDetected ? "TRUE" : "FALSE");
    lastState = motionDetected;
  }

  // 🔥 READ VB COMMANDS
  if (Serial.available() > 0) {
    String command = Serial.readStringUntil('\n');
    command.trim();
    command.toUpperCase();

    // gate control
    if (waitingDecision && command == "ACCEPT") {
      gateServo.write(90);
      digitalWrite(GREEN, HIGH);
      digitalWrite(RED, LOW);
      waitingDecision = false;
    } 
    else if (waitingDecision && command == "DECLINE") {
      gateServo.write(0);
      digitalWrite(GREEN, LOW);
      digitalWrite(RED, HIGH);
      waitingDecision = false;
    }

    // LCD control
    if (command == "FULL SLOT") {
      lcd.setCursor(0,0);
      lcd.print("Parking is     ");
      lcd.setCursor(0,1);
      lcd.print("on full slot   ");
    } 
    else if (command == "VACANT") {
      lcd.setCursor(0,0);
      lcd.print("Boni's         ");
      lcd.setCursor(0,1);
      lcd.print("Parking lot    ");
    }

    if (command == "EXIT") {
      gateServo.write(90);
      delay(3000);
      gateServo.write(0);
    }
  }

  delay(100); // 🔥 reduced delay for responsiveness
}