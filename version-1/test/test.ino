
void setup() {
  pinMode(13, OUTPUT);
}

void loop() {
  if(millis() % 2000 < 1000) {
    digitalWrite(13, HIGH);
  }
  else {
    digitalWrite(13, LOW);
  }
}
