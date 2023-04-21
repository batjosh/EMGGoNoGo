// Pin numbers for buttons and analog input
const int button1Pin = 7;
const int button2Pin = 8;
int muscle;
//const int analogInputPin = A0;
//int ana

void setup() {
  // Initialize serial communication
  Serial.begin(115200);

  // Set button pins as inputs with pull-up resistors
  pinMode(button1Pin, INPUT_PULLUP);
  pinMode(button2Pin, INPUT_PULLUP);
}

void loop() {
  // Read button states
  int button1State = digitalRead(button1Pin);
  int button2State = digitalRead(button2Pin);

  // Check if button 1 is pressed
  if (button1State == LOW) {
    Serial.println("0,0,1,0,0");  
  }

  // Check if button 2 is pressed
  if (button2State == LOW) {
    Serial.println("0,0,0,1,0");
  }

  // Read analog input value
  muscle = analogRead(A0);

  // Print analog input value on serial monitor
  Serial.println("0,0,0,0," + String(muscle));
  

  // Add a delay to avoid reading the buttons and analog input too quickly
  delay(100);
}
