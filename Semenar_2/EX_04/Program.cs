/* Задача 14. Напишите программу, которая принимает на вход число
и проверяет, кратно ли оно одновременно 7 и 23*/

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int x = 7;
int y = 23;
if (num%x == 0 && num%y == 0 )
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}