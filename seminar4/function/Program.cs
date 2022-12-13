int test (int a, int b) //string / b=10
{
     if (a > b) 
     return a; //">"
     return b; //"<"
}

Console.Clear();
Console.Write("Введите 1-е число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(test(n, m));