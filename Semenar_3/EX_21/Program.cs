/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21*/

Console.Clear();
Console.Write("Введите коорадинату X точки A:");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите коорадинату Y первой A:");
int y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите коорадинату X второй B:");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите коорадинату Y второй B:");
int y2 = int.Parse(Console.ReadLine()!);

double dist(int x1, int x2, int y1, int y2)
{
    double result;
    result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    //res = Math.Round(res, 3); // вывод до 3 знаков после запятой
    return result;
}

Console.WriteLine($"Длинна отрезка АВ равно:{dist(x1, x2, y1, y2)}");

// :f2 - округление 2 знака после запятой