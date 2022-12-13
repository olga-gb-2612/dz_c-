// умножение пар элементов,1ый с последним, 2ой с предпоследним и тд

void inputArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
     array[i] = new Random().Next(1,11); 
}

int[] ReleaseArray(int[] array)
{
int[] result = new int[array.Length/2+array.Length%2];
for (int i = 0; i <array.Length/2 + array.Length%2; i++)
 result[i]=array[i]*array[array.Length -1-i];
 return result;
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
inputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"[{string.Join(", ", ReleaseArray(array))}]");
