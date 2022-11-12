/*17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта точка.*/

Console.Clear();
Console.Write("X:");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Y:");
int y = int.Parse(Console.ReadLine()!);
if (x > 0)  //x+
{
    if (y > 0)  //y+
    {
         Console.WriteLine("Первая четверть");
    }
    else    //y-
    {
         Console.WriteLine("Чертвёртая четверть");
    }
}
else       //x-
{
    if (y > 0)  //y+
    {
         Console.WriteLine("Вторая четверть");
    }
    else        //y-
    {
         Console.WriteLine("Третья четверть");
    }
}