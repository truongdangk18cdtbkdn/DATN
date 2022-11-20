#include <Servo.h> // Khai báo thư viện servo

Servo myservo;// Tạo đối tượng tên myservo
Servo myServo2;

int pos = 0;//Tạo biến nhận giá trị góc quay
int pos2 = 0;
int input1 = 8;
int input2 = 10;
bool status1 = false;
bool status2 = false;

void setup() {
  myservo.attach(3,500,2500);  // Chân 3, Chu kỳ Min, Max
  myServo2.attach(5, 500, 2500);
  pinMode(input1, INPUT_PULLUP);
  pinMode(input2, INPUT_PULLUP);
  pinMode(13, OUTPUT);
  status1 = false;
  status2 = false;
}

void servo1Go() {
  digitalWrite(13, 1);
  for (pos = 160; pos >= 100; pos -= 1) { 
    myservo.write(pos);            
    delay(7);                      
  }
}
void servo1Back(){
  digitalWrite(13, 0);
  for (pos = 100; pos <= 160; pos += 1) { 
    myservo.write(pos);              
    delay(7);                      
  }
}
void servo2Go() {
  digitalWrite(13, 1);
  for (pos = 180; pos >= 80; pos -= 1) { 
    myServo2.write(pos);            
    delay(7);                      
  }
}
void servo2Back(){
  digitalWrite(13, 0);
  for (pos = 80; pos <= 180; pos += 1) { 
    myServo2.write(pos);              
    delay(7);                      
  }
}

void loop() {
  if (status1 == false && digitalRead(input1) == LOW) {
    servo1Go();
    delay(500);
    status1 = true;
  }
  if (status1 == true && digitalRead(input1) == HIGH) {
    servo1Back();
    delay(500);
    status1 = false;
  }
  if (status2 == false && digitalRead(input2) == LOW) {
    servo2Go();
    delay(500);
    status2 = true;
  }
  if (status2 == true && digitalRead(input2) == HIGH) {
    servo2Back();
    delay(500);
    status2 = false;
  }
}
