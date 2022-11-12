// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Composition(int n)
{
    int mult = 1;
    for (int i = 1; i <= n; i++)
    {
        mult = mult * i;
    }
    return mult;
}

Console.Clear();
Console.WriteLine();
Console.Write("Введите число: ");
int X = int.Parse(Console.ReadLine()!);
Console.Write("Произведение чисел: ");
Console.Write(Composition(X));