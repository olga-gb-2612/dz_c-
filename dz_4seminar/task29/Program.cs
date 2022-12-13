Console.Clear();
Console.Write("Введите кол-во элементов массива:");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
for(int i = 0; i < a; i++)
{
Console.Write($"Введите {i}-ый элемент массива:");
array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"[{string.Join(", ", array)}]");