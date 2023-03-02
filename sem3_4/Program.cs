// на вход координаты 2 точик и над\ходит расстояние м-у ними

int[] pointsa = new int[2];

Console.WriteLine("Введите x и y для т.а");
for (int ia = 0; ia < pointsa.Length; ia = ia + 1)
pointsa[ia]= Convert.ToInt32(Console.ReadLine());

int[] pointsb = new int[2];

Console.WriteLine("Введите x и y для т.б");
for (int ib = 0; ib < pointsb.Length; ib = ib + 1)
pointsb[ib]= Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt( Math.Pow(pointsa[0] - pointsb[0] , 2) + Math.Pow(pointsa[1] - pointsb[1] , 2 )) ;
Console.WriteLine("Расстояние равно " + Math.Round (result,2));