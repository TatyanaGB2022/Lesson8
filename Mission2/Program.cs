// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j=i;j<arr.GetLength(1);j++)
        {
        temp = arr[i,j];
        arr[i,j] = arr[j,i];
        arr[j,i] = temp;    
        }
            }
}
int[,]massive = new int [5,5];
FillArray(massive);
PrintArray(massive);
System.Console.WriteLine();
Change(massive);
PrintArray(massive);