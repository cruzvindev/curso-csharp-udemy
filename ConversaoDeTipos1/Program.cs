Console.WriteLine("Conversão de Tipos !\n");

//Conversão Implícita 
int varInt = 100;
double varDouble = varInt;

//Conversão Explícita
double varDoublee = 12.456; //8 Bytes
int varIntt = (int)varDoublee; //4 Bytes
Console.WriteLine(varIntt);

int num1 = 4;
int num2 = 2;

float resultado = (float)num1 / num2;
Console.WriteLine(resultado);