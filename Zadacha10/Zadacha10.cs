//Задача 10: Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает вторую цифру этого числа.
System.Console.WriteLine("Enter number: ");
string StrN = System.Console.ReadLine();
int number = Convert.ToInt32(StrN);
if (number<100|number>999)
  {
    System.Console.WriteLine("Число должно быть трехзначным");
  }
else 
  {
    int Ndigits=number/10;
    int Nresult=Ndigits%10;
    System.Console.WriteLine(Nresult);
  }