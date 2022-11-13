// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8" 

string GetPrint(int start, int end)
{
    if (start == end)
    {
        return start.ToString();

    }
    Console.WriteLine($"{start}");
    return start + " " + GetPrint(start + 1, end);
}
Console.Clear();
Console.Write("Ввведите число M:");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Ввведите число N:");
int n = int.Parse(Console.ReadLine()!);
Console.Write(GetPrint(m, n));