
bool dataReceived;

byte userInput[2];
byte stepsCount;
byte stepDelay;

// the setup function runs once when you press reset or power the board
void setup() {
  // initialize digital pin 13 as an output.
  pinMode(13, OUTPUT);
  Serial.begin(9600);
}

// the loop function runs over and over again forever
void loop() {
  getDataFromSerial();
 
     if(dataReceived){
      for (byte i = 0; i < stepsCount; i++ ){
          digitalWrite(13, HIGH);   // turn the LED on (HIGH is the voltage level)
          delay(70);              // wait for a second
          digitalWrite(13, LOW);    // turn the LED off by making the voltage LOW
          delay(stepDelay * 1000); 
          }
   }      
}

void getDataFromSerial(){
  dataReceived = false;
    if (Serial.available() > 2) {
    // Read the first byte
   byte startbyte = Serial.read();
    // If it's really the startbyte (255) ...
    if (startbyte == 255) {
      // ... then get the next two bytes
      for (byte i=0;i<2;i++) {
        userInput[i] = Serial.read();
      }
      stepsCount = userInput[0];
      stepDelay = userInput[1];
   } 
   dataReceived = true;
 }
}
