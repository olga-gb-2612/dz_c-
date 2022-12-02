Console.Clear();
Console.Write("Введите число, обозначающее день недели:");
int A = Convert.ToInt32(Console.ReadLine()); 
if (A < 1 || A > 7)
   Console.Write("Ошибка!");
else if ( A == 6 || A == 7)
   Console.Write("да");
else
   Console.Write("нет");