//показывает кол-во четных чисел в массиве.

void inputArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
     array[i] = new Random().Next(100,1000); 
}


void ReleaseArray(int[] array)
{
   int count=0;
   for (int i = 0; i <array.Length; i++)
   {
    if (array[i] %2 == 0)
       count++ ;
   }
   Console.WriteLine($"Кол-во четных чисел в массиве : {count}");
  
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
inputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);

