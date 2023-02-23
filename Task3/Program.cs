Console.WriteLine("Number");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case (3):
    Console.WriteLine("Sreda");
    break;
    case (1):
    Console.WriteLine("Poned");
    break;
    case (2):
    Console.WriteLine("Vtornik");
    break;
    case (4):
    Console.WriteLine("Chetv");
    break;
    case (5):
    Console.WriteLine("Piatnica");
    break;
    case (6):
    Console.WriteLine("Ssybota");
    break;
     case (7):
    Console.WriteLine("Voskr");
    break;
    default: 
    Console.WriteLine("Ne vernoe hcislo");
    break;
}