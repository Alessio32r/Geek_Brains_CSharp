// Задача “со звездочкой”: Напишите функцию, которая принимает одно число - 
//высоту елочки и рисует ее в консоли звездочками.

Console.Clear();

void Main(string[] args)
{
    int height = int.Parse(Console.ReadLine()!);
    string x = "*";
    for (int i = 0; i <height ; i++)
    {
        Console.WriteLine(x);
        x += "*";        
    }
}