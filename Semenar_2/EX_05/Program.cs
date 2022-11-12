/* Задача . Напишите программу, которая принимает на вход два числа
и проверяет, является ли одно квадратом другого */

Console.Clear();
Console.Write("Введите число 1: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine()!);

//            ||  - or, или

if (num == num2 * num2 || num2 == num * num)
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("НЕ является");
}