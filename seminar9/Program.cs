// Рекурсия
// 65 Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
Console.WriteLine("Введите значение m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n");
int n = Convert.ToInt32(Console.ReadLine());

string Number(int m, int n)
{
    if (m==n)
   return m.ToString();
   return m + " " + Number(m+1,n);
   }
   Console.WriteLine(Number(m,n));
*/
    
// 67 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9
/*
Console.WriteLine("Введите число");
int m = Convert.ToInt32(Console.ReadLine());

int Number(int m)
{
   if (m / 10 == 0)

   return m;
   return m%10 + Number(m/10);
}
Console.WriteLine();
Console.Write("Сумма элементов числа = ");
Console.WriteLine(Number(m));*/

// 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
/*
Console.WriteLine("Введите значение A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение B");
int B = Convert.ToInt32(Console.ReadLine());

int Step(int A, int B)
{
   if (B==0)
   return 1;
   //if (B==1)
  // return A;
   return A * Step(A,B-1);
   }

Console.WriteLine();
Console.Write("Число А в степени В = ");
Console.WriteLine(Step(A,B));
Console.WriteLine();
*/


