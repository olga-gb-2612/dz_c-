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

void SearchMatr(int[,] matrix, int r, int c)
{
    if (r>matrix.GetLength(0) || c> matrix.GetLength(1))
{
    Console.Write("Такой позиции в массиве нет");
}
else
   Console.Write(matrix[r-1,c-1]);
}

Console.Clear();
Console.Write("Введите позиции элемента в массиве: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int row = new Random().Next(2, 11); 
int column = new Random().Next(2, 11);
 int[,] matrix = new int[row, column];
InputMatrix(matrix);
SearchMatr(matrix, size[0], size[1]);
