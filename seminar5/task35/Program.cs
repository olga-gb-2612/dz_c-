// выводит кол-во элементом от 10 до 100

void inputArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
     array[i] = new Random().Next(-100,101); 
}

int ReleaseArray(int[] array)
{
int count = 0;
for (int i = 0; i <array.Length; i++)
{
 if (array[i] > 9 && array[i] < 100)
 count++;
}
return count;
}


Console.Clear();
int[] array = new int[123];
inputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(ReleaseArray(array));
