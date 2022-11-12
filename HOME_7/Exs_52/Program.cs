// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическоеэлементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] numbers = new int[row, columns];
GetArray(numbers);
PrintArray(numbers);

Console.WriteLine("Cреднее арифметическое элементов по столбцам столбце: ");
double avarage = 0;
for (int j = 0; j < numbers.GetLength(1); j++)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / row;
    avarage = Math.Round(avarage,2);
    Console.Write(avarage + "; ");
}
// Методом среднее (avarage) сделать не получилось, сколько я ни бился, всё время приводит к 
// "error CS0266: Не удается неявно преобразовать тип "double" в "int".

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}");
        }
        Console.Write(" ]");
        Console.WriteLine();
    }
}