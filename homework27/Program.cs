// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Вариант решения №1 

int SumDigit(int N)
{
int lenght = N.ToString().Length;
int sum = 0;
int sum2 = 0;
for ( int i = lenght; i >0; i--)
{
int sum1 = N / Convert.ToInt32(Math.Pow(10, i-1));
sum+= sum1 - sum2*10;
sum2 = sum1;
}
return sum;
}
 int GetNumberFromConsole(string message)
 {
    Console.WriteLine( message );
    return int.Parse(Console.ReadLine());
 }
    int N = GetNumberFromConsole ("A =");
     Console.Write("Сумма цифр числа =");
     Console.WriteLine(SumDigit(N));

// Вариант решения №2

// int SumDigit(int N)
// {
// while (N>1)
// {
// int sum+ = N % 10 ;
// }
// return sum;
// }
//  int GetNumberFromConsole(string message)
//  {
//     Console.WriteLine( message );
//     return int.Parse(Console.ReadLine());
//  }
//     int N = GetNumberFromConsole ("A =");
//      Console.Write("Сумма цифр числа =");
//      Console.WriteLine(SumDigit(N));