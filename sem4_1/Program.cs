// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int Prompt()
{
Console.WriteLine("Введите число");
return Convert.ToInt32(Console.ReadLine());
}

int SumNum(int number)
{
int sum = 0;
for (int i = 1; i <= number; i++);
   sum = sum + i;
return sum;
}

int a = Prompt();
Console.WriteLine(SumNum(a));