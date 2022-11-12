﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] Array(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

Console.Clear();
int[] array = Array(6, 100, 1000);
Console.WriteLine(String.Join(", ", array));
int PositiveNumbers = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        PositiveNumbers++;
    }
}
Console.WriteLine("Количество чётных чисел в массиве:" + PositiveNumbers);