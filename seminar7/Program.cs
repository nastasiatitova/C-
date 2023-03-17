// массив 2мерный 3*4
/*
int[,] CreatCutputArray(int m, int n)
{
  int[,] array = new int[m,n];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1,11);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
  return array;
}
CreatCutputArray(3,4);
*/

// 48 Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n
/*
int[,] CreateOutputArray(int m, int n)
{
  int[,] array = new int[m,n];
  for (int i = 0; i < array.GetLength(0); i++)
  {
  for (int j = 0; j < array.GetLength(1); j++)
    {
    array[i,j] = i+j;
    
    Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
  }
  return array;
}
CreateOutputArray(3,4);
*/

// 49 Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
int[,] CreateArray()
{
  int[,] array = new int[6,5];
  for (int i = 0; i < array.GetLength(0); i++)
  {
  for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1,50);
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
    }
  return array;
}

int[,] newarr = CreateArray();

int[,] ModyArray(int[,] newarr)
{
  for (int i = 0; i < newarr.GetLength(0); i++)
  {
  for (int j = 0; j < newarr.GetLength(1); j++)
    {
        if (i %2 == 0 && j %2 == 0)
        newarr[i,j] = newarr[i,j] * newarr[i,j];
        Console.Write(newarr[i,j] + "\t");
    }
    Console.WriteLine();
    }
  return newarr;
}

Console.WriteLine();
ModyArray(newarr);
*/

// 51 Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int Promt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] CreateOutputArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}

int SummOfElements(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
                sum += matrix[i, j];
        }
    }
    return sum;
}

int m = Promt("Введите количество строк: ");
int n = Promt("Введите количество столбцов: ");

Console.WriteLine();
Console.WriteLine("Сумма элементов " + SummOfElements(CreateOutputArray(m, n)));