// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Random rand = new Random();
int number = rand.Next(100,1000);
Console.WriteLine("Случайное число это - " + number);

int num1 = number / 100;
int num2 = number % 10;
Console.Write(num1);
Console.WriteLine(num2);
