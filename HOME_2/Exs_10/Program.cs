/*Задача 10: Напишите программу, которая на вход прнимает трёхзначное число 
и на выходе показывает вторую цифру этого числа*/

Console.Clear();
Console.Write("Введите трёхзначное число : ");
int num = int.Parse(Console.ReadLine()!);
int a1 = (num % 100)/10;
Console.WriteLine($"Второй цифра {a1}");