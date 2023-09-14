// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            Console.Write($"{matrix[i, j], 3}");
        }
        Console.WriteLine();
    }
}

int[,] CreateProductMatrices (int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int result = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result += matrix1[i,k] * matrix2[k,j];
            }
        resultMatrix[i,j] = result;
        }
    }
    return resultMatrix;
}

int[,] matrixOne = CreateMatrixRndInt(2, 2, 0, 5);
Console.WriteLine("Матрица 1: ");
PrintMatrix(matrixOne);
Console.WriteLine();

int[,] matrixTwo = CreateMatrixRndInt(2, 2, 0, 5);
Console.WriteLine("Матрица 2: ");
PrintMatrix(matrixTwo);
Console.WriteLine();

Console.WriteLine("Произведение матриц 1 и 2 равно: ");
int[,] productMatrix = CreateProductMatrices(matrixOne, matrixTwo);
PrintMatrix(productMatrix);