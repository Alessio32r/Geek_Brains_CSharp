//Задача 2: Напишите программу, которая на вход принимается 
//два числа и выдаёт, какое число больше, а какое меньше

Console.Clear();
Console.WriteLine("Введите первое число: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int y = int.Parse(Console.ReadLine()!);
if (x > y)
{
    Console.WriteLine("Первое число " + x + " больше чем второе " + y);
}
else
{
    Console.WriteLine("Второе число " + y + " больше чем первое " + x);
}