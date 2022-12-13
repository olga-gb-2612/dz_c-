void test (ref int a) // ref передача по ссылке, с массивами не работает.
{
    a += 5;
}

Console.Clear();
Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
test(ref n);
Console.WriteLine(n);

//процедуры для повторения участка кода