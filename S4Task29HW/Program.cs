// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

Console.Write("Введите размер массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент массива: ");
int minNumArr = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int maxNumArr = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(sizeArr, minNumArr, maxNumArr);
Console.WriteLine();
PrintArray(array);