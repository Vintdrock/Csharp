int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        int[,] matrix = new int[n, m];
      int step = 1;
      // Введите свое решение ниже
      for (int i = 0; i < n; i++)
        {        
            for (int j = 0; j < m; j++)
            {
                matrix [i,j] = step;
                step = step + k;
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
            Console.Write($"{arr[i, j], 3}");
        }
        Console.WriteLine();
    }
}

double [] FindAverageInColumns (int [,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double avarage = 0;
      
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        avarage = (avarage + matrix[i, j]);
      
    }
    array[j] = avarage / matrix.GetLength(0);
    }
      return array;
    }

void PrintArray1(double[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]:F2}");
    }
    Console.Write("]");
}



int[,] matrix = CreateIncreasingMatrix(3, 4, 2);
PrintArray(matrix);
double[] array2d = FindAverageInColumns(matrix);
PrintArray1(array2d);