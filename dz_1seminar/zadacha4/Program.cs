Console.Write("Введите первое число:");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:");
int C = Convert.ToInt32(Console.ReadLine());
if( A >= B && A >= C )
     Console.WriteLine($"MAX = {A}");
else if (B >= A && B >= C)
     Console.WriteLine($"MAX = {B}");
else 
     Console.WriteLine($"MAX = {C}");
