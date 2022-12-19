// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void InputMatrix(int[,,] array)
{
    int i, j, k;
    Console.WriteLine("Enter values of array -> ");
    for (k = 0; k < array.GetLength(2); k++)
    {
        for (i = 0; i < array.GetLength(0); i++)
        {
            for (j = 0; j < array.GetLength(1); j++)
            {
                array[i, j, k] = int.Parse(Console.ReadLine());
            }
        }
    }
}

void PrintMatrix(int[,,] array)
{
    int i, j, k;
    Console.WriteLine("-------------------------------------------------");
    for (k = 0; k < array.GetLength(2); k++)
    {
        for (i = 0; i < array.GetLength(0); i++)
        {
            for (j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine("-------------------------------------------------");
}

Console.Clear();
int[,,] array3D = new int[2, 2, 2];

InputMatrix(array3D);
PrintMatrix(array3D);