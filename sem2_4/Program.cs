// 2 числа на вход, проверить кратность

Console.WriteLine("Number1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number2");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.Write("не кратно, остаток ");
    Console.WriteLine(number1 % number2);
}
