// met1

//void Metod1()
//{
//Console.WriteLine("Автор ....");
//}
//Metod1();

//met2

//void Metod2(string msg)
//{
//Console.WriteLine(msg);
//}
//Metod2("текст такой");

//met21

//void Metod21(string msg, int count)
//{
//int i = 0;
//while (i < count)
//{
   // Console.WriteLine(msg);
   // i++;
//}
//}
//Metod21("Hello", 5);

//met3

//int Metod3()
//{
//return DateTime.Now.Year; //- обязательное использование оператора return,
//}
//int year = Metod3();
//Console.WriteLine(year);

//met4

//string Metod4(int count, string text)
//{
//int i = 0;
//string result = String.Empty;
//while (i<count)
//{
//result = result + text;
//i++;
//}
//return result;
//}
//string res = Metod4(3, "гусь ");
//Console.WriteLine(res);

//таблица умножения

//for (int i = 2; i < 10; i++)
//{
//for (int j = 2; j < 10; j++)
//{
//Console.WriteLine($"{i} * {j} = {i * j}");
//}
//Console.WriteLine();
//}

//работа с текстом

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля."
+ "Вы так красноречивы. Вы дадите мне чаю?";

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
int length = text.Length;
for (int i = 0; i < length; i++)
{
if(text[i] ==oldValue) result = result + $"{newValue}";
else result = result + $"{text[i]}";
}
return result;
}
string newText = Replase(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();

newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replase(newText, 'с', 'С');
Console.WriteLine(newText);
