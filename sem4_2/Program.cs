//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int Prompt()
{
Console.WriteLine("Введите число");
return Convert.ToInt32(Console.ReadLine());
}
/*
int Chislo(int number)
{
int i = 1;
while (number /10!= 0)
{
    number = number / 10;
    i= i+1;
}
return i;
}
 int a = Prompt();
 Console.WriteLine(Chislo(a));
*/
 //28

int a = Prompt();

int NumMultiply (int number)
{
/*int multiply = 1;
int i = 1;
while (i <= number)
{
multiply = multiply * i;
i=i+1;
}*/
 int multiply=1;
for (int i = 1; i <= number; i++)
       multiply *=i;
return multiply;
}
Console.WriteLine(NumMultiply(a));
