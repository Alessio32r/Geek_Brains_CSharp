// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами такой длины.

int[] array = new int[3];

bool CheckTriangle(int a, int b, int c)
{
    return a + b > c && a + c > b && b + c > a;
}

for (int i = 0; i < 3; i++)
{
    array[i] = int.Parse(Console.ReadLine()!);
}

if (CheckTriangle(array[0], array[1], array[2]))
{
    Console.WriteLine("Существует");
}
else
{
    Console.WriteLine("НЕ существует");
}