// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
//+
int Prompt()
{
Console.WriteLine("Введите количество элементов массива");
return Convert.ToInt32(Console.ReadLine());
}

int size = Prompt();

int[] GenerateArray()
{
int [] array = new int [size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,10);
}
return array;
}


int[] ReversArray(int[] array)
{
    int tmp = 0;
for (int i = 0; i < array.Length/2; i++)
{
    tmp = array[i];
    array[i] = array[array.Length-1-i];
    array[array.Length-1-i] = tmp;
}
return array;
}

int[] array = GenerateArray();
Console.WriteLine(String.Join(" , ", array));
Console.WriteLine(String.Join(" , ", ReversArray(array)));


// 40 Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


// 40+
/*
int Prompt(string message)
{
Console.WriteLine(message);
string ReadInput = Console.ReadLine();
int result = int.Parse(ReadInput);
return result;
}
int a = Prompt("Введите первое число");
int b = Prompt("Введите второе число");
int c = Prompt("Введите третье число");

if (a < b+ c && b < a+c && c < a+b)

Console.WriteLine("Такой треугольник возможен");  
else  Console.WriteLine("Такой треугольник не возможен");  
*/

//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//+
/*
int Prompt()
{
Console.WriteLine("Введите число");
return Convert.ToInt32(Console.ReadLine());
}

int number = Prompt();

string input = " ";
while (number > 0)
{
input += number%2;
number /= 2;
}
Console.WriteLine(input);

string Revers(string input)
{
   char[] charArray = input.ToCharArray();
   Array.Reverse(charArray);

return new string(charArray);
}
Console.Write(Revers(input));
*/

//44 вывести первые N чисел Фибоначчи.
//45 сделать копию массива

//44 + 
/*
int Prompt()
{
Console.WriteLine("Введите число");
return Convert.ToInt32(Console.ReadLine());
}

int number = Prompt();

int[] array = new int[number];
    array[0] = 0;
    array [1] = 1;
    Console.Write(array[0] + " ");
    Console.Write(array[1] + " ");

    for (int i = 2; i < number; i++)
    {
      array[i] = array [i-2] + array[i-1];
 Console.Write(array[i] + " ");
    }
*/

//45 +
/*
int Prompt()
{
Console.WriteLine("Введите количество элементов массива");
return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
int size = Prompt();

int[] GetArray()
{
int [] array = new int [size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0,11);
}
return array;
}

int[] newarray = GetArray();
Console.WriteLine("Первый массив");
Console.Write(string.Join(" | ", newarray));

int[] coparray = new int[size];
for (int i = 0; i < newarray.Length; i++)
{
    coparray[i] = newarray[i];
}

Console.WriteLine("Второй массив");
Console.Write(string.Join(" | ", coparray));
*/