Console.Clear();
Console.Write("Введите трехзначное число:");
int A = Convert.ToInt32(Console.ReadLine()); 
if (A > 99 && A < 1000)
 Console.Write((A % 100)/10);
else
 Console.Write("Ошибка!");



