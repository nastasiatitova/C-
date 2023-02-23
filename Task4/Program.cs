
Console.WriteLine("Number");
int number = Convert.ToInt32(Console.ReadLine());
int count = -number;
Console.WriteLine("Vivod chisel");
while (count<=number)
{
   Console.Write(" " + count);
   count = count+1;
}