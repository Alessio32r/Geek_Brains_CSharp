// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void RandomArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}

Console.WriteLine("Введите желаемый размер массива:  ");
int size = int.Parse(Console.ReadLine()!);
double[] numbers = new double[size];
RandomArray(numbers);
Console.WriteLine(String.Join(", ", numbers));
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
Console.WriteLine($"Максимальное значение: {max}, минимальное значение: {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением: {max - min:f2}");