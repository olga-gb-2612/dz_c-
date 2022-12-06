Console.Clear();
Console.Write("Введите номер четверти:");
int x = Convert.ToInt32(Console.ReadLine());
if (x == 1 || x == 2)
  Console.WriteLine("y > 0");
else
  Console.WriteLine("y < 0");

if (x == 1 || x == 4)
  Console.WriteLine("x > 0");
else
  Console.WriteLine("x < 0");
