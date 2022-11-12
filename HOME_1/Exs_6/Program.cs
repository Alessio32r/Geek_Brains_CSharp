//Задача 6: Напишите программу, которая на вход принимается число и выдаёт, является ли 
// число чётным (делитя ли оно на два без остатка)

Console.Clear();
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
if (num % 2 == 1)
{
    Console.WriteLine("Число " + num + "-> НЕчётное");
}
else
{
    Console.WriteLine("Число " + num + "-> Чётное");
}
