// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Number1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number2");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2 || number2 == number1*number1)

   Console.WriteLine("да"); 

else Console.WriteLine("нет");
