// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Sum(int A)
{
    int sum = 0;
    for (int i=0; i<=A; i++ )
    {
        sum +=i;
    }
    return sum;
}

Console.Clear();
Console.WriteLine();
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(Sum (n));
