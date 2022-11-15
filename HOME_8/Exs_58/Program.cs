// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размерность матрицы:");
int matrixSize = int.Parse(Console.ReadLine()!);
int[,] matrixA = GetArray(matrixSize, matrixSize, 0, 9);
int[,] matrixB = GetArray(matrixSize, matrixSize, 0, 9);

int[,] matrixC = new int[matrixSize, matrixSize];
for (int i = 0; i <matrixSize; i++)
{
    for (int j = 0; j < matrixSize; j++)
    {
        for (int k = 0; k < matrixSize; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}

Console.WriteLine("Первая матрица: ");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц: ");
PrintArray(matrixC);