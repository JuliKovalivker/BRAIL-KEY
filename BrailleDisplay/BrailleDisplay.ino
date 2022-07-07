#include <Servo.h>

int off[6] = {165, 12, 140, 5, 2, 172};
//int off[6] = {130, 50, 120, 40, 20, 150};
int on[6] = {156, 19, 132, 14, 7, 165};
int pos[6] = {0, 2, 4, 1, 3, 5};
String r;
int req;
String request;
char move;


Servo servos[6];


void setup()
{
  servos[0].attach(3, 500, 2500);
  servos[1].attach(5, 500, 2500);
  servos[2].attach(6, 500, 2500);
  servos[3].attach(9, 500, 2500);
  servos[4].attach(10, 500, 2500);
  servos[5].attach(11, 500, 2500);
  
  servos[0].write(off[0]);
  servos[1].write(off[1]);
  servos[2].write(off[2]);
  servos[3].write(off[3]);
  servos[4].write(off[4]);
  servos[5].write(off[5]);
  
  Serial.begin(9600);
}

void loop()
{
  if (Serial.available()) {

    r = Serial.readString();
    req = r.toInt();
    request = "";
    for(int i = 0; i < 6; i++)
    {
      if (req % 2 == 1){
        request = request + "1";
      }
      else{
        request = request + "0";
      }
      req = req / 2;
    }

    
    
        
    for (int i = 5; i >= 0; i--)
    {
      if (request[i] == '0'){
        servos[pos[i]].write(off[pos[i]]);
      }
      else{
        servos[pos[i]].write(on[pos[i]]);  
      }
    }
  }
}
