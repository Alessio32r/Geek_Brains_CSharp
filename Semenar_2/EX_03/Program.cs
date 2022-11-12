/*Напишите программу, которая будет принимать на вход 2 числа и выводить,
является ли второе число кратным первому. Если 2 число не кратно 1, то прорамма будет выводить остаток от деления*/

Console.Clear();
Console.Write("Введите первое число: ");
int a1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите первое число: ");
int a2 = int.Parse(Console.ReadLine()!);

int x = a2 % a1;
int y = a2 / a1;
if (x == 0)
{
    Console.WriteLine($"{a2} кратно {a1}");
}
else
Console.WriteLine($"Остаток от деления {y}");