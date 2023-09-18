// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void SumNaturalNumbers(int from, int to, int sum)
{
    int temp = 0;
    if (from > to) 
    {
        temp = from;
        from = to;
        to = temp;
    }
    sum = sum + from;
    if(from >= to)
    {
        Console.Write($"Сумма элементов равна: {sum}");
        return;
    }
     SumNaturalNumbers(from + 1, to, sum);
}

Console.WriteLine("Введите диапазон натуральных чисел");
Console.Write("Введите M: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

SumNaturalNumbers(numberOne, numberTwo, 0);