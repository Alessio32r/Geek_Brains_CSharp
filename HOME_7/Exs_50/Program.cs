// Задача 50. Напишите программу, которая на вход принимает число и возвращает индексы элемента
// в двумерном массиве или же указание, что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void SearchNumber(int[,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number) 
            {
                Console.WriteLine($"Число найдено на строке {i + 1} в столбеце {j + 1}");
                return;
                //+1 подобавил, потому что неудобно пользователю 
                //визуально проверять правильность считая с нуля колонки и строки, неинтуитивно понятно.
            }
        }
    }
    Console.WriteLine("Число не найдено");
}

void PrintArray(int[,] inArray) // печать массива
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

int[,] GetArray(int m, int n, int minValue, int maxValue) //заполнение рандомными числами
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    return result;
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите искомое число: ");
int number = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, columns, 0, 10);
PrintArray(array);
Console.WriteLine("Ищем число " + number + " в массиве:");
SearchNumber(array, number);