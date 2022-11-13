// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 

int GetPow(int num, int power)
{
    if (power == 0)
    {
        return 1;
    }
    return num * GetPow(num, power - 1);
}

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
int p = int.Parse(Console.ReadLine()!);
Console.Write($"{n}^{p} = " + GetPow(n, p));