// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArrayManual(int size)
{
    int[] arr = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1}-й элемент массива : ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int NumbersThanZero(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count ++;
    }
    return count;
}

Console.Write("Введите размер массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayManual(sizeArr);
Console.WriteLine();
int numbersThanZero = NumbersThanZero(array);
Console.WriteLine($"Элементов больше нуля -> {numbersThanZero}");