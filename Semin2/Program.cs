// Напишите программу, которая выводит случайное 
// число из отрезка [10, 99] и показывает наибольшую цифру числа

Random rand = new Random();
int number = rand.Next(10,100);
Console.WriteLine("Случайное число это - " + number);
int max = number / 10;
int min = number % 10;

if (max>min)
{
    Console.WriteLine("Наибольшая цифра числа это {0}", max);
}
else
Console.WriteLine("Наибольшая цифра числа это {0}", min);

