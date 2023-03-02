// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int[] points = new int[2];

Console.WriteLine("Введите x && y");
for (int i = 0; i < points.Length; i = i + 1)
points[i]= Convert.ToInt32(Console.ReadLine());

   if (points[0] >0 && points [1] >0) //x  y
Console.WriteLine("Это 1 четверть");
else if (points[0] <0 && points [1] >0) 
Console.WriteLine("Это 2 четверть");
else if (points[0] >0 && points [1] <0) 
Console.WriteLine("Это 3 четверть");
else if (points[0] <0 && points [1] <0) 
Console.WriteLine("Это 4 четверть");
else Console.WriteLine("x && y = 0");