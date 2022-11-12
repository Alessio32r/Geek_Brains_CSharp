// Задача 21: Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double distance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double result;
    result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return result;
}

Console.Clear();
Console.Write("Введите коорадинату X точки A:");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите коорадинату Y первой A:");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите коорадинату Z точки A:");
int z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите коорадинату Y первой B:");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите коорадинату X второй B:");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите коорадинату Z второй B:");
int z2 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Длинна отрезка АВ равно:{distance(x1, x2, y1, y2, z1, z2):f2}");