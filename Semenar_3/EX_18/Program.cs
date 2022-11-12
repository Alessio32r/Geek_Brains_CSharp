/*Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).*/

Console.Clear();
Console.Write("Введите номер четверти:");
int num = int.Parse(Console.ReadLine()!);
switch (num)
{
    case 1:
        {
            Console.WriteLine("x>0");
            Console.WriteLine("y>0");
            break;
        }
    case 2:
        {
            Console.WriteLine("x<0");
            Console.WriteLine("y>0");
            break;
        }
    case 3:
        {
            Console.WriteLine("x<0");
            Console.WriteLine("y<0");
            break;
        }
    case 4:
        {
            Console.WriteLine("x>0");
            Console.WriteLine("y>0");
            break;
        }
    default:
        {
            Console.WriteLine("Введите номер другой четверти:");
            break;
        }
}


/*if (num < 1 || num > 4)
{
    Console.WriteLine("Введите номер другой четверти:");
}
else if (num == 1)
{
    Console.WriteLine("x>0");
    Console.WriteLine("y>0");
}
else if (num == 2)
{
    Console.WriteLine("x<0");
    Console.WriteLine("y>0");
}
else if (num == 3)
{
    Console.WriteLine("x<0");
    Console.WriteLine("y<0");
}
else if (num == 4)
{
    Console.WriteLine("x>0");
    Console.WriteLine("y<0");
}
*/