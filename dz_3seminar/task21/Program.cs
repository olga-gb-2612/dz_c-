Console.Clear();
Console.Write("Введите координату х1:");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y1:");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z1:");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату х2:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y2:");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z2:");
double z2 = Convert.ToDouble(Console.ReadLine());

double res = Math.Sqrt (Math.Pow(x1-x2, 2)+Math.Pow(y1-y2, 2)+Math.Pow(z1-z2, 2));
Console.Write(Math.Round(res, 2));
