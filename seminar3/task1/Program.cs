Console.Clear();
Console.Write("Введите координату х:");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y:");
double y = Convert.ToDouble(Console.ReadLine());

while (x == 0)
{
    Console.Write("Вы ошиблись!\nВведите координату х:");
    x = Convert.ToDouble(Console.ReadLine());
}
while (y == 0)
{
    Console.Write("Вы ошиблись!\nВведите координату y: ");
    y = Convert.ToDouble(Console.ReadLine());
}
if (x > 0 && y > 0)
    Console.Write("I");
else if (x > 0 && y < 0)
    Console.Write("II");
else if (x < 0 && y < 0)
    Console.Write("III");  
else
    Console.Write("IV"); 

