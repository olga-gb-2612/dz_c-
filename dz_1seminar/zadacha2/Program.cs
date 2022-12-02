Console.Write("Введите первое число:");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int B = Convert.ToInt32(Console.ReadLine());
if (A > B)
Console.WriteLine($"MAX = {A}, MIN = {B}");
else
Console.WriteLine($"MAX = {B}, MIN = {A}");