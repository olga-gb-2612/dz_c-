// перевернуть массив

void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
       array[i] = new Random().Next(1,11);
}

void ReleaseArray(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int t = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = t;
    }
}

Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
