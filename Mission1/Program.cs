// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }

}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void Change(int[,] arr)
{
    var temp = 0;
    int lastNum = arr.GetLength(0) - 1;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        temp = arr[0,i];
        arr[0,i] = arr[lastNum,i];
        arr[lastNum,i] = temp;    
    }
}

int [,] matrix = new int [3,3];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Change(matrix);
PrintArray(matrix);