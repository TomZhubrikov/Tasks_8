// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void InputMatrix(int[,] A)
{
    int i, j;
    for (i = 0; i < A.GetLength(0); i++)
    {
        for (j = 0; j < A.GetLength(1); j++)
        {
            A[i, j] = new Random().Next(1, 100);
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

void Swap (int[,] A, int i, int j1, int j2) {
    int c = A[i, j1];
    A[i, j1] = A[i, j2];
    A[i, j2] = c;
}

void SortMatrix(int[,] A) {
    int i, j1, j2, max, jmax;
    for (i = 0; i < A.GetLength(0); i++)
    {
        for (j1 = 0; j1 < A.GetLength(1) - 1; j1++)
        {
            max = A[i, j1];
            jmax = j1;
            for (j2 = j1 + 1; j2 < A.GetLength(1); j2++)
            {
                if (A[i, j2] > max) {
                    max = A[i, j2];
                    jmax = j2;
                }          
            }
            Swap(A, i, j1, jmax);
        }
    }
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
SortMatrix(matrix);
PrintMatrix(matrix);
