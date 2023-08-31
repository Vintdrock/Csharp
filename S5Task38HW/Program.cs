// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F2}, ");
        else Console.Write($"{arr[i]:F2}");
    }
    Console.Write("]");
}

double FindMaxNumberArray (double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
            {
                max = arr[i];
            }
    }
    return max;
}
double FindMinNumberArray (double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
            {
                min = arr[i];
            }
    }
    return min;
}


Console.Write("Введите размер массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArrayRndDouble(sizeArr, 10, 50);
Console.WriteLine();
PrintArrayDouble(array);
Console.WriteLine();
double maxNumberArray = FindMaxNumberArray(array);
double minNumberArray = FindMinNumberArray(array);
Console.WriteLine($"Максимальное значение = {maxNumberArray:F2}");
Console.WriteLine($"Минимальное значение = {minNumberArray:F2}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {maxNumberArray - minNumberArray:F2}");