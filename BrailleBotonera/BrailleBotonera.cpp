bool uno = false;
bool dos = false;
bool tres = false;
bool cuatro = false;
bool cinco = false;
bool seis = false;
bool siete = false;
int total = 0;

void setup() {
  pinMode(3, INPUT);
  pinMode(4, INPUT);
  pinMode(5, INPUT);
  pinMode(6, INPUT);
  pinMode(7, INPUT);
  pinMode(8, INPUT);
  pinMode(9, INPUT);
  Serial.begin(9600);
}

void loop() {
 
  while (digitalRead(3) == HIGH || digitalRead(4) == HIGH || digitalRead(5) == HIGH || digitalRead(6) == HIGH || digitalRead(7) == HIGH || digitalRead(8) == HIGH || digitalRead(9) == HIGH)
	{
  	if (digitalRead(3) == HIGH)
  	{
      	delay(50);
      	uno = true;
  	}
 	 
  	if (digitalRead(4) == HIGH)
  	{
      	delay(50);
      	dos = true;
  	}
 	 
  	if (digitalRead(5) == HIGH)
  	{
      	delay(50);   	 
      	tres = true;
  	}
 	 
  	if (digitalRead(6) == HIGH)
  	{
      	delay(50);   	 
      	cuatro = true;
  	}
 	 
  	if (digitalRead(7) == HIGH)
  	{
      	delay(50);  	 
      	cinco = true;
  	}
 	 
  	if (digitalRead(8) == HIGH)
  	{
      	delay(50);   	 
      	seis = true;
  	}
 
  	if (digitalRead(9) == HIGH)
  	{
      	delay(50);   	 
      	siete = true;
  	}	 
	}
 
  if (tres == true)
  {
  	total += 1;
  }
 
  if (dos == true)
  {
  	total += 2;
  }
 
  if (uno == true)
  {
  	total += 4;
  }
 
  if (cinco == true)
  {
  	total += 8;
  }
 
  if (seis == true)
  {
  	total += 16;
  }
 
  if (siete == true)
  {
  	total += 32;
  }
 
  if (cuatro == true)
  {
  	total += 0;
  }
   



  if (uno == true || dos == true || tres == true || cuatro == true || cinco == true || seis == true || siete == true)
  {
  	Serial.print(total);
  	total = 0;
  	uno = false;
  	dos = false;
  	tres = false;
  	cuatro = false;
  	cinco = false;
  	seis = false;
  	siete = false;
  }
}
