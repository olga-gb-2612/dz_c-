Console.Clear();
Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
while(n > 0)
{
    count++;
    n/=10;
}
Console.WriteLine(count);