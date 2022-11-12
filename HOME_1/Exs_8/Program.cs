//Задача 8: Напишите программу, которая на вход примимается число N,
//а на выходе показывает все чётные от 1 до N

Console.Clear();
Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine()!);
int res = 1;
if (res == 1)
{
    res = res+1;
}
//добавим 1 что бы стало чётным
while (res <= N)
{
    Console.WriteLine(res);
    res = res + 2;
}
// будем добавлять по 2

// с отрицательными числами чёт не работает