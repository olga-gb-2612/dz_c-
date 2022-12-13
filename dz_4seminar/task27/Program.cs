Console.Clear();
Console.Write("Введите число, где цифры записываются через пробел:");
string[] a = Console.ReadLine().Split(' ');
int sum =0;
for (int i = 0; i < a.Length; i++)
    sum += int.Parse(a[i]);
Console.Write(sum);


