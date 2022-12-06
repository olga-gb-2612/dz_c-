Console.Clear();
Console.Write("Введите число:");
int x = Convert.ToInt32(Console.ReadLine());
for (int i =1; i <=x; i++)
  Console.Write($"{Math.Pow(i, 3)} "); 