// ввод 3зн число, вывод последнюю цифру
Console.WriteLine("Number");
int number = Convert.ToInt32(Console.ReadLine());
int div = 0;
if (number>=100 && number<1000)
{
    div = number % 10;
    Console.WriteLine(div);
}
else
{
Console.WriteLine("Ne tot Number");
}