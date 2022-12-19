// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

void InputMatrix(int[,] A)
{
    int i, j;
    for (i = 0; i < A.GetLength(0); i++)
    {
        for (j = 0; j < A.GetLength(1); j++)
        {
            A[i, j] = new Random().Next(1, 11);
        }
    }
}

void PrintMatrix(int[,] A)
{
    int i, j;
    Console.WriteLine("-------------------------------------------------");
    for (i = 0; i < A.GetLength(0); i++)
    {
        for (j = 0; j < A.GetLength(1); j++)
        {
            Console.Write($"{A[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("-------------------------------------------------");
}
 
void FindMaxSumString(int[,] A) {
    int i, j, iMinSum = 0, minSum = 0, sum;
    for (i = 0; i < A.GetLength(0); i++)
    {
        sum = 0;
        for (j = 0; j < A.GetLength(1); j++)
        {
            sum += A[i, j];
        }
        if (i == 0) minSum = sum;
        else if (minSum > sum) {
            minSum = sum;
            iMinSum = i;
        }
    }
    Console.WriteLine($"The row with the smallest sum -> {iMinSum} (numbering from 0)");
}

Console.Clear();
Console.WriteLine("Enter a size of matrix [n, m]: ");
Console.Write("n -> ");
int n = int.Parse(Console.ReadLine());
Console.Write("m -> ");
int m = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, m];

InputMatrix(matrix);
PrintMatrix(matrix);
FindMaxSumString(matrix);