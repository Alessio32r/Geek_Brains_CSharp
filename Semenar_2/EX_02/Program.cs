/* Напишите программму, которая выводит случайное трёхзначное 
число и удаляется вторую цифру этого числа*/

/*Console.Clear();
int num = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерировано число {num}");
int a1 = num / 100;
int a2 = num % 10;
Console.WriteLine($"Число без второй цифры {a1}{a2}");*/

Console.Clear();
int num = new Random().Next(100, 1000);

Console.WriteLine($"Сгенерировано число {num}");

int a1 = num / 100;
a1 = a1 * 10;

int a2 = num % 10;
Console.WriteLine($"Число без второй цифры {a1 + a2}");