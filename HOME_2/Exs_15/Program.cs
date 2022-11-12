/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным*/

Console.Clear();
Console.Write("Введите число дня недели:");
int x = int.Parse(Console.ReadLine()!);
if (x == 1)
{
    Console.WriteLine("Понедельник");
}
else if (x == 2)
{
    Console.WriteLine("Вторник");
}
else if (x == 3)
{
    Console.WriteLine("Среда");
}
else if (x == 4)
{
    Console.WriteLine("Четверг");
}
else if (x == 5)
{
    Console.WriteLine("Пятница");
}
else if (x == 6)
{
    Console.WriteLine("Суббота");
}
else if (x == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Нет такого дня недели");
}
if (x == 6 || x == 7 )
{
    Console.WriteLine("УРА ВЫХОДНОЙ");
}
if (x == 1 || x == 2 || x == 3 || x == 4 || x == 5 )
{
    Console.WriteLine("ИДИ РАБОТАЙ");
}