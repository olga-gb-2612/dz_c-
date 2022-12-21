// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
double[] count = new double[matrix.GetLength(1)];  // не додумала как это можно все в функцию/процедуру запихнуть.
for (int i = 0; i < matrix.GetLength(0); i++)
{

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        count[j] += matrix[i, j];
    }
}

for (int i = 0; i < count.Length; i++)
{
    count[i] = count[i] / matrix.GetLength(0);
    Math.Round(count[i], 2);
}

Console.WriteLine($"[{string.Join(", ", count)}]");

