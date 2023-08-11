﻿//9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа. 78 -> 8 12-> 2 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число в диапазоне 10-99 -> {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");


//Тернарный оператор

int result = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшая цифра числа -> {result}");

//Метод (Функции)

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    //int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");
