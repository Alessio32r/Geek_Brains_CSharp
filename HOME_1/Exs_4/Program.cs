//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное
//из этих трёх числел

Console.Clear();
Console.WriteLine("Введите три числа:");
int number_1 = int.Parse(Console.ReadLine()!);
int number_2 = int.Parse(Console.ReadLine()!);
int number_3 = int.Parse(Console.ReadLine()!);
int max = number_1;

if (number_2 > max)
{
    max = number_2;
}
if (number_3 > max)
{
    max = number_3;
}
Console.WriteLine("Наибольшее число " + max);