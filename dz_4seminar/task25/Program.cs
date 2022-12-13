// Написать цикл, к-ый принимаетна вод числа а и в и возводит 
// число а в натуральную степень б

Console.Clear();
Console.Write("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень:");
int b= Convert.ToInt32(Console.ReadLine());
int res = 1;
for(int i=1; i<=b;i++)
res=res*a;
Console.WriteLine (res);
