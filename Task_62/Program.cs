// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void InputMatrix(int[,] A)
{
    int i, j, count = 0, n = A.GetLength(0);
    for (i = 0; i < n; i++)
    {
        for (j = 0; j < n; j++, count++)
        {
            A[i, j] = count;
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

Console.Clear();
int[,] matrix = new int[4, 4];

InputMatrix(matrix);
PrintMatrix(matrix);
