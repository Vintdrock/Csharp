﻿// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Factorial(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            mult *= i; // sum = sum + i
        }
    }
    return mult;
}

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(number);

if(number < 1)
{
    Console.WriteLine("Введено некорректное число");
    return;
}

Console.WriteLine($"Произведение чисел от 1 до {number} = {factorial}");