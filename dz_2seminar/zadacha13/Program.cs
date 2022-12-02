Console.WriteLine("Hello, World!");
Console.Clear();
Console.Write("Введите любое число:");
int A = Convert.ToInt32(Console.ReadLine()); //ругается при вводе числа из более 10 цифр
int B = A + 0; // потребовалось продубировать число чтобы использовать его в конечной формуле, тк А обнуляется после цикла подсчета кол-ва цифр в числе
int res = 0;
while ( A > 0){  // цикл подсчета цифр в числе
 A /= 10;
 res++; 
}
if (res == 1 || res == 2)
   Console.WriteLine("Третьей цифры нет");
else  {
int T = Convert.ToInt32(Math.Pow(10,res-3)); 
Console.WriteLine((B/T) % 10);          //смысл : формула отбрасывает все цифры после трех и находит остаток от деления на 10
}