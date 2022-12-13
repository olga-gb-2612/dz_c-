//есть ли указанное число в массиве 

void inputArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
     array[i] = new Random().Next(-9,10); 
}

string ReleaseArray(int[] array, int k)
{
for (int i = 0; i <array.Length; i++)
 {if (array[i] == k)
  return "yes";
 }
return "no";
}

Console.Clear();
Console.Write("Введите число для проверки: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
inputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(ReleaseArray(array, k));


