﻿//Напишите программу, которая по заданному номеру 
//четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
int number = Convert.ToInt32(Console.ReadLine());


if (number == 1)
Console.WriteLine("x>0 && Y>0");
else if (number == 2)
Console.WriteLine("x<0 && Y>0");
else if (number == 3)
Console.WriteLine("x<0 && Y<0");
else if (number == 4)
Console.WriteLine("x>0 и Y>0");
else Console.WriteLine("Введено тнекорректный номер");

