// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите позиции элемента в массиве: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int row = new Random().Next(2, 11); 
int column = new Random().Next(2, 11);
 int[,] matrix = new int[row, column];
InputMatrix(matrix);

if (size[0]>matrix.GetLength(0) || size[1]> matrix.GetLength(1))
{
    Console.Write("Такой позиции в массиве нет");
}
else
   Console.Write(matrix[size[0]-1,size[1]-1]);

