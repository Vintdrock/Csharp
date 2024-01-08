// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

//ЗАДАНИЕ ВХОДНЫХ МАССИВОВ (комментим/раскомменчиваем строки для теста)
string[] array1 = {"Hello", "2", "world", ":-)"};
// string[] array1 = {"1234", "1567", "-2", "computer science"};
// string[] array1  = {"Russia", "Denmark", "Kazan"};

// задаяем новый пустой массив
string[] array2 = new string[array1.Length];

CreateArray3Symbol(array1);
PrintArray(array2);


// метод создания нового массива по условиям задачи
void CreateArray3Symbol(string[] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
    Array.Resize(ref array2, count);
}
//метод вывода массива
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}