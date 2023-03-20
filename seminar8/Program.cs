//  53+: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
/*
int Promt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int m = Promt("Введите количество строк: ");
int n = Promt("Введите количество столбцов: ");

Console.WriteLine();
Console.WriteLine("Начальный массив");

int[,] CreateOutputArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}

int[,] matrix = CreateOutputArray(m,n);

void ExchangeArray(int[,] matrix)
{
int tmp;
int lastIndex = matrix.GetLength(0) - 1;

for (int i = 0; i < matrix.GetLength(1); i++)
    {
        tmp = matrix[lastIndex,i];
        matrix[lastIndex,i] = matrix[0,i];
        matrix[0,i] = tmp;
    }   
}

void OutputArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

Console.WriteLine();
Console.WriteLine("Новый массив");
ExchangeArray(matrix);
OutputArray(matrix);
*/

// 55+
/*
int Promt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int m = Promt("Введите количество строк: ");
int n = Promt("Введите количество столбцов: ");
Console.WriteLine();

int[,] CreateOutputArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
     return matrix;
     Console.WriteLine();
}


int[,] ExchangeArray(int[,] matrix)
{
    int[,] array = new int[matrix.GetLength(0),matrix.GetLength(1)];
   for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        array[j,i] = matrix[i,j];
    }
    }
       return array;
}

void OutputArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

if (n==m)
{
int[,] matrix = CreateOutputArray(m,n);
Console.WriteLine();
int[,] array = ExchangeArray(matrix);
OutputArray(array);
}
else Console.WriteLine("Это сделать невозможно");
*/

// 57+: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int Promt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int m = Promt("Введите количество строк: ");
int n = Promt("Введите количество столбцов: ");
Console.WriteLine();

int[,] CreateArray(int m, int n)
{
  int[,] array = new int[m,n];
  for (int i = 0; i < array.GetLength(0); i++)
  {
  for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1,10);
        Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
  return array;
  Console.WriteLine();
}

int[,] array = CreateArray(m,n);

Console.WriteLine();

int[] ExchangeArray(int[,] array)
{
    int count = 0;
    int[] newarray = new int[array.GetLength(0)*array.GetLength(1)];
for (int i = 0; i < array.GetLength(0); i++)
  {
  for (int j = 0; j < array.GetLength(1); j++)
    {
     newarray[count] = array[i,j];
     count ++;
    }
  }
return newarray;
}

Console.WriteLine(String.Join(", ",ExchangeArray(array)));

int[] newarray = ExchangeArray(array);

int[] Sorter(int[] newarray)
{
    Array.Sort(newarray);
    return newarray;
}

int[] sortarray = Sorter(newarray);

Console.WriteLine();
Console.WriteLine(String.Join(", ", sortarray));

int count = 1;
int el = newarray[0];
for (int i = 1; i < newarray.Length; i++)
{
if (el == newarray[i])
{
count++;
}
else 
{
    Console.WriteLine("Число " + el + " - " + count + "раз");
count = 1;
el = newarray[i];
}
}

Console.WriteLine("Число " + el + " - " + count + "раз");

