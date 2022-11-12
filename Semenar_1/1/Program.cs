//Напишите прорамму, которая на вход принимает 2 числа и проверяет, 
//является ли первое число квадратом второго

Console.Clear();
Console.Write("Введите первое число:");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:");
int y = int.Parse(Console.ReadLine()!);
if (y * y == x) 
{
    Console.WriteLine("ДА!");
}
else
{
    Console.WriteLine("Нет!");
}
