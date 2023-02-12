//Задача 15: Напишите программу, которая принимает на вход
//цифру, обозначающую день недели, и проверяет, является ли
//этот день выходным.
System.Console.WriteLine("Enter number of the day of the week: ");
string StrD = System.Console.ReadLine();
int Day = Convert.ToInt32(StrD);
if (Day>0&Day<8)
  {
    System.Console.WriteLine("day of the week: ");
  }
else
  {
    System.Console.WriteLine("Wrong number");
  }