#include <Servo.h>


Servo myservo; 
Servo myservo2;

const int PIN = 3;
const int SV_PIN = 5;
const int SV_PIN2 = 7;
byte parameter;

void setup() 
{
  Serial.begin(9600);
  pinMode(PIN, OUTPUT);
  digitalWrite(PIN, HIGH );

  myservo.attach(SV_PIN, 500, 2400);  // サーボの割り当て(パルス幅500~2400msに指定)
  myservo.write(0);                   // サーボモーターを0度の位置まで動かす
     
  myservo2.attach(SV_PIN2, 500, 2400);  // サーボの割り当て(パルス幅500~2400msに指定)
  myservo2.write(0);                   // サーボモーターを0度の位置まで動かす
  delay(2000); 
  // put your setup code here, to run once:
}


void tennisHaptics()
{
  if ( Serial.available() )
  {
    parameter = Serial.read();
  }

  myservo.write(parameter);
  myservo2.write(parameter);

  
}

void loop() 
{
  tennisHaptics();
  // put your main code here, to run repeatedly:
}
