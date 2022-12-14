//сумма эл-ов на нечетных позициях масссива

void inputArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
     array[i] = new Random().Next(-100,100); 
}


void ReleaseArray(int[] array)
{
   int sum=0;
   for (int i = 0; i <array.Length; i++)
   {
    if ( i % 2 != 0)
       sum += array[i];
   }
   Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях : {sum}");
  
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
inputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);