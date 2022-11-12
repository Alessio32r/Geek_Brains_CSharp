// Задача 27: Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int NumberSum(int x)
{
    int res = 0;
    while (x > 0)
    {
        res = res + (x % 10);
        x = x / 10;
    }
    return res;
}

Console.WriteLine("Введите какое-нибудь число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {number} равна:{NumberSum(number)}");