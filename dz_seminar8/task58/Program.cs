// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

int[,] MultiMatrix(int[,] matrix, int[,] matrix1)
{
    int[,] matrixC = new int[matrix.GetLength(0),matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrixC[i,j] = matrix[i,j]*matrix1[i,j];
        }
    }
    return matrixC;
}

Console.Clear();
Console.Write("Введите размерность матриц: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrixA = new int[size[0], size[1]];
int[,] matrixB = new int[size[0], size[1]];
Console.WriteLine("Матрица А:");
InputMatrix(matrixA);
PrintMatrix(matrixA);
Console.WriteLine("Матрица B:");
InputMatrix(matrixB);
PrintMatrix(matrixB);
Console.WriteLine("Произведение матриц А и В:");
PrintMatrix(MultiMatrix(matrixA,matrixB));