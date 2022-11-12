//Напишите программу,которая на вход принимает 3-х значное число и ны выходе показывает последнию цифру

Console.Clear();
Console.Write("Введите число:");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{x%10}");
