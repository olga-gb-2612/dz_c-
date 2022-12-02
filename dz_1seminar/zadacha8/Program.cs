Console.Clear();
Console.Write("Введите число:");
int A = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= A; i++ )
{
    if (i % 2 == 0)
      Console.WriteLine(i);
}
