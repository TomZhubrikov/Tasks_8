// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void InputMatrix(int[,] A)
{
    int i, j;
    Console.WriteLine("Enter values of matrix -> ");
    for (i = 0; i < A.GetLength(0); i++)
    {
        for (j = 0; j < A.GetLength(1); j++)
        {
            A[i, j] = int.Parse(Console.ReadLine());
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

int[,] MatrixMultiplication(int[,]A, int[,]B) {
    int i, j, sum, ist, jst;
    int[,] AB = new int[A.GetLength(0), B.GetLength(1)];
    for (i = 0; i < AB.GetLength(0); i++)
    {
        for (j = 0; j < AB.GetLength(1); j++)
        {
            sum = 0;
            for (ist = 0, jst = 0; ist < A.GetLength(1); ist++, jst++) {
                sum += A[i, jst] * B[ist, j];
            }
            AB[i, j] = sum;
        }
    }
    return AB;
}

Console.Clear();
Console.WriteLine("Enter a size of first matrix A[n, m]: ");
Console.Write("n -> ");
int n = int.Parse(Console.ReadLine());
Console.Write("m -> ");
int m = int.Parse(Console.ReadLine());
int[,] matrix1 = new int[n, m];
Console.WriteLine("Enter a size of second matrix B[m, k]: ");
Console.Write("k -> ");
int k = int.Parse(Console.ReadLine());
int[,] matrix2 = new int[m, k];

InputMatrix(matrix1);
PrintMatrix(matrix1);
InputMatrix(matrix2);
PrintMatrix(matrix2);
PrintMatrix(MatrixMultiplication(matrix1, matrix2));
