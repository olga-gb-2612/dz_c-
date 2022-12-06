Console.Clear();
Console.Write("Введите число:");
int x = Convert.ToInt32(Console.ReadLine());
for (int i =1; i <=x; i++)
  Console.Write($"{i*i} "); // можно через Math.Pow(i, 2)
