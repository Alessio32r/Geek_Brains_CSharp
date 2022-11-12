﻿/*Задача 23: Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

void ListSqrd(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write($"{i * i * i}");
        if (i != n)
        {
            Console.Write(", ");
        }
    }
}
Console.Clear();
Console.Write("Введите N:");
int N = int.Parse(Console.ReadLine()!);
ListSqrd(N);