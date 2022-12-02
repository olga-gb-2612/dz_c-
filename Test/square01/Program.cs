Console.Clear();

Console.Write("Введите число для возведения в квадрат:");
int A = Convert.ToInt32(Console.ReadLine());
int Res = A * A;
Console.Write("Результат:");    
Console.Write(Res);
//Console.WriteLine($"Результат = {A * A}"); интерполяция