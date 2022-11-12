// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Count(int a)
{
    int count = 0;
    if (a == 0)
    {
        return 1;
    }
    while (a != 0)
    {
        count++;
        a = a / 10;
    }
    return count;
}

Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine()!);
int result = Count(A);
Console.WriteLine(result);