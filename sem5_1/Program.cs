//задача 31 ниже +
/*
int[] GetArray()
{
int [] array = new int [12];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9,10);
}
return array;
}

int[] newarray = GetArray();

int SumPozitiv()
{
int sum=0;
for (int i = 0; i < newarray.Length; i++)
{
    if (newarray[i] > 0)
    sum += newarray[i];
}
return sum;
}

int SumNegativ()
{
int sum=0;
foreach (int el in newarray)
sum += el < 0? el : 0;
return sum;
}

Console.WriteLine(String.Join(" ", newarray));
Console.WriteLine("Сумма положительных {0}. Сумма отрицательных {1}", SumPozitiv(), SumNegativ());
*/

//  32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 
//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// 32 задача +

//moe
/*
int Prompt()
{
Console.WriteLine("Введите количество элементов массива");
return Convert.ToInt32(Console.ReadLine());
}

int size = Prompt();

int[] GetArray()
{
int [] array = new int [size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-10,11);
}
return array;
}

int[] newarray = GetArray();
Console.WriteLine(string.Join(" ", newarray));

void ChangeNumber()
{
for (int i = 0; i < newarray.Length; i++)
{
    newarray[i] = newarray[i] * -1;
}
}
ChangeNumber();
Console.WriteLine(String.Join(" ", newarray));
*/

//33 +
/*
int Prompt()
{
Console.WriteLine("Введите количество элементов массива");
return Convert.ToInt32(Console.ReadLine());
}

int size = Prompt();

int [] GetArray()
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

int[] newarray = GetArray();
Console.WriteLine(String.Join(" ", newarray));

int Prompt2()
{
Console.WriteLine("Введите число от 0 до 99");
return Convert.ToInt32(Console.ReadLine());
}

int find = Prompt2();
int index = 0;
int b = 0;

while (index<size)
{ 
 if (newarray[index] == find)
{
    Console.WriteLine("Искомый элемент найден в массиве");
    b++;
    break;
    }
index ++;
}
  if (b ==0)
  {
    Console.WriteLine("Искомый элемент не найден в массиве");
  }
*/


//через bool не поняла

/*bool FindDigit (int[] array, int num)
{
for (int i = 0; i < array.Length; i++)
{
    if (Array[i] == num)
    return true;
}
return false;
}*/


//35 - Задайте одномерный массив из 123 случайных чисел. //Найдите количество элементов массива, значения которых лежат в отрезке [10,99]
// + 
int [] GetArray()
{
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 200);
    }
    return array;
}

int[] newarray = GetArray();

int Count()
{
   int count = 0;
for (int i = 0; i < newarray.Length; i++)
 {
    if (newarray[i] <=99 && newarray[i]>=10)
count +=1;
 }
return count;
}


Console.WriteLine(String.Join(" ", newarray));
int cou = Count();
Console.WriteLine("Количество чисел из диапозона 10/99 " + "- " + cou);


//36 +
/*
int [] GetArray()
{
    int[] array = new int[11];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 150);
    }
    return array;
}
int[] newArray = GetArray();

int MultInd(int[] newArray)
{
   int num = newArray.Length/2;
if (newArray.Length %2==1)
 num ++; 
 int[] smolArray = new int[num];
for (int i = 0; i < smolArray.Length; i++)
{
    smolArray[i] = newArray[i]*newArray[newArray.Length-1 - i];
}
if (num % 2 ==0)
smolArray[num-1] = newArray[newArray.Length/2];
return smolArray;
}
Console.WriteLine(String.Join(" ", newArray));
Console.WriteLine(String.Join(" ", MultInd(newArray)));
*/

