#include <Servo.h> // Khai báo thư viện servo

Servo myservo;// Tạo đối tượng tên myservo
Servo myServo2;

int pos = 0;//Tạo biến nhận giá trị góc quay
int pos2 = 0;
int input1 = 8;
int input2 = 9;
bool status1;
bool status2;
bool posNow1;
bool posNow2;

void setup() {
  myservo.attach(3);  // Chân 3, Chu kỳ Min, Max
  myServo2.attach(5);
  pinMode(input1, INPUT_PULLUP);
  pinMode(input2, INPUT_PULLUP);
  pinMode(13, OUTPUT);
  digitalWrite(13, LOW);
  myservo.write(175);
  myServo2.write(173);
  status1 = false;
  status2 = false;
}

void servo1Go() {
  digitalWrite(13, 1);
  for (pos = 175; pos >= 90; pos -= 1) { 
    myservo.write(pos);            
    delay(7);                      
  }
}
void servo1Back(){
  digitalWrite(13, 0);
  for (pos = 90; pos <= 175; pos += 1) { 
    myservo.write(pos);              
    delay(7);                      
  }
}
void servo2Go() {
  digitalWrite(13, 1);
  for (pos = 173; pos >= 80; pos -= 1) { 
    myServo2.write(pos);            
    delay(7);                      
  }
}
void servo2Back(){
  digitalWrite(13, 0);
  for (pos = 80; pos <= 173; pos += 1) { 
    myServo2.write(pos);              
    delay(7);                      
  }
}

void loop() {
  bool inp1 = digitalRead(input1);
  bool inp2 = digitalRead(input2);
  if (status1 == false && status2 == false && inp1 == LOW) {
    servo1Go();
    delay(500);
    status1 = true;
  }
  else if (status1 == true && inp1 == HIGH) {
    servo1Back();
    delay(500);
    status1 = false;
  }
  else if (status2 == false && status2 == false && inp2 == LOW) {
    servo2Go();
    delay(500);
    status2 = true;
  }
  else if (status2 == true && inp2 == HIGH) {
    servo2Back();
    delay(500);
    status2 = false;
  }
  else {
    // do not thing
  }
}
