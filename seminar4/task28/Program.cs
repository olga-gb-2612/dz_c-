Console.Clear();
Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine()),fact=1;
for(int i=2; i<=n; i++)
{
    fact=fact*i;
}
Console.WriteLine(fact);
