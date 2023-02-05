// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит 
// информацию о том, сколько раз встречается элемент входных данных. 
// Значения элементов массива 0..9


void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
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

int[] Freq(int[,] arr)
{
    int[] num = new int[10];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            num[arr[i,j]]++;
        }
    }
    return num;
}
int[,]massive = new int [5,5];
FillArray(massive);
PrintArray(massive);
var freqArr = Freq (massive);

for(int i=0; i < freqArr.Length; i ++)
{
    System.Console.WriteLine($"{i}- {freqArr[i]}");

}



// int[] FrequencyDictionary(int[,] array)
// {
//     int[] numbers = new int[10];
//     foreach (int item in array)
//     {
//       numbers[item]++;
//     }
//     return numbers;
// }