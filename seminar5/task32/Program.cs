// замена эл-ов массива: положительные замените на отрицательные, и наоборот.

void inputArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
     array[i] = new Random().Next(-9,10); 
}


void OtriPol(int[] array)
{
    for(int i = 0; i <array.Length; i++)
       array[i]=array[i]*(-1);  
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
inputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
OtriPol(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
