// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
48. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.

int[,] CreateMatrixSumIndexes(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void PrintArray(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            Console.Write($"{arr[i, j], 5}");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrixSumIndexes(3, 4);
PrintArray(matrix);