﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29



int Akk(int m, int n)
{
    if (m==0)
        return n+1;
    else if (m !=0 && n==0)
        return Akk(m-1, 1);
    else 
        return Akk(m-1, Akk(m,n-1));
}


Console.Clear();
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
while (m < 0)
{
    Console.Write("Вы ошиблись!\nВведите положительное число m: ");
    m = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 0)
{
    Console.Write("Вы ошиблись!\nВведите положительное число n: ");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(Akk(m, n));
