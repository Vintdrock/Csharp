// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 2}");
        }
        Console.WriteLine();
    }
}

int [] FindSumInRows (int [,] matrix)
{
    int[] array = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = (sum + matrix[i, j]);
        }
        array[i] = sum;
    }
    return array;
}

int FindMinSumRows(int[] arr)
{
    int indexMin = 0;
    int min = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) 
        {
            min = arr[i];
            indexMin = i;
        }
    }
    return indexMin;
}

int[,] matrix = CreateMatrixRndInt(5, 5, 0, 9);
Console.WriteLine("Матрица: ");
PrintMatrix(matrix);
Console.WriteLine();
int[] sumArray = FindSumInRows(matrix);
int stringNum = FindMinSumRows(sumArray);
Console.WriteLine($"Строка с наименьшей суммой элеменов -> {stringNum + 1}, которая равна -> {sumArray[stringNum]}");