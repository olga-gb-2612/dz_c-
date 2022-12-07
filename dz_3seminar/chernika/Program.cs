Console.Clear();
Console.Write("Введите количество кустов на грядке:");
int N = Convert.ToInt32(Console.ReadLine());
int[] x = new int[N];
int max = 0;
// for (int i =1; i <N; i++)
for (int index = 0; index < x.Length; index++)
{
    x[index] = new Random().Next(1, 10);
    Console.WriteLine(x[index]);
}

Console.WriteLine();

if ( x[1] > x[x.Length-2])
  max = x[0] + x[1] + x[x.Length-1];
else
  max = x[0] + x[x.Length-2] + x[x.Length-1];

for (int i = 1; i < x.Length-1; i++) 
  { 
    if (x[i-1] + x[i] + x[i+1] > max)
    max = x[i-1] + x[i] + x[i+1];
   }
Console.WriteLine(max);