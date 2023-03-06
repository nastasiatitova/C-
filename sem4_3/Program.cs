// массив из 8 эл-в  -  0 1 в случ порядке

int Prompt()
{
Console.WriteLine("Введите количество элементов");
return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int size) 
{
int [] array = new int [size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0,2);
}
return array;
} 

int[] newArray = CreateArray(Prompt());

Console.WriteLine($"[{String.Join(", " , newArray)}]");