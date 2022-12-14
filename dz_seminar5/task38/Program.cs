//разница м/у макс и мин элементом массива

void inputArray(double[] array)
{
    for(int i=0; i<array.Length; i++)
     array[i] =new Random().Next(-100,100) + Math.Round(new Random().NextDouble(), 2); 
}


void ReleaseArray(double[] array)
{  
   double max=array[0], min=array[0];
   for (int i = 1; i <array.Length; i++)
   {
    if ( array[i] > max)
       max= array[i];
    else if (array[i] < min)
       min =array[i];
   }
   Console.WriteLine($"Разница м/у максимальным и минимальным элементом массива : {Math.Round(max - min, 2)}");
  
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
inputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);