/*Напишите программу, которая выводит случайные 
числа из отрезка 10 ...99 и показывает наибольшую цифру числа*/

Console.Clear();

// [отрезок] в отрезок всех числа входят 
//[полуинтервал) в полуинтервал не входит последнее число

int num = new Random().Next(10, 100);
int a1 = num / 10;
int a2 = num % 10;
int max = a1;
if (max < a2)
{
    max = a2;
}
Console.WriteLine($"Максим цифра в числе {num} -> {max}");

