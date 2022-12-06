Console.Clear();
Console.Write("Введите пятизначное число:");
string? x = Console.ReadLine();

while ( x.Length > 5 || x.Length < 5 )
{
    Console.Write("Вы ошиблись!\nВведите пятизначное число:");
    x = Console.ReadLine();
}
if (x[0]==x[4] && x[1]==x[3])
  Console.WriteLine("да");
else
  Console.WriteLine("нет");