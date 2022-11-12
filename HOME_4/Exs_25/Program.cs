// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную
// степень B. Реализовать функцию возведения в степень самостоятельно!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int ThirdDegree (int a, int b)
{
    int res = 1;
    for (int i = 1; i <= b; i++)
    {
      res = res *a;
    }
    return res;
}

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень:");
int degree = int.Parse(Console.ReadLine()!);
Console.WriteLine(ThirdDegree(number, degree));