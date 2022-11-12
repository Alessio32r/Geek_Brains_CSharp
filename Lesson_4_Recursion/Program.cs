//строки и столбцы нумеруются с нуля
//String.empty
//table[0.0]    //table[0.1]    //table[0.2]    //table[0.3]
//table[1.0]    //table[1.1]    //table[1.2]    //table[1.3]
//table[2.0]    //table[2.1]    //table[2.2]    //table[2.3]
//table[3.0]    //table[3.1]    //table[3.2]    //table[3.3]

// string[,] table = new string[2, 5];
// table[1, 2] = "слово";
// for (int rows = 0; rows < 2; rows++)  //rows- строки
// {
//     for (int columns = 0; columns < 5; columns++) // columns - колонки
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

int[,] matrix = new int[3, 4];

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FilltArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

PrintArray(matrix);
Console.WriteLine();
FilltArray(matrix);
PrintArray(matrix);