﻿//Напишите программу, которая выводит третью
//цифру заданного числа или сообщает, что третьей цифры нет.
System.Console.WriteLine("Enter number: ");
string StrN = System.Console.ReadLine();
int number = Convert.ToInt32(StrN);
int absnumber=Math.Abs(number);
int Ndigits=1;
int Ndivided=(absnumber/10);
while (Ndivided>=1)
   {
      Ndigits++;
      Ndivided=Ndivided/10;
   }
int[] arrayN=new int[Ndigits];
int index=Ndigits-1;
int Ndivided1=(absnumber%10);
while (index>=0)
   {
      arrayN[index]=Ndivided1;
      Ndivided1=Ndivided1/10;
      index=index-1;
      System.Console.WriteLine("итерация");
   }
   var str = string.Join(" , ", arrayN);
   Console.WriteLine(str);