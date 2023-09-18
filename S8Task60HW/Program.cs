﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] FillArrayRandom(int a, int b, int c)
{
    int[,,] matrix = new int[a, b, c];
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    matrix[i, j, k] = new Random().Next(1, 10);
                }
            }
        }
    return matrix;
}

Console.Write("Введите натуральное число: ");
int numberX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число: ");
int numberY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число: ");
int numberZ = Convert.ToInt32(Console.ReadLine());
int[,,] newArr3D = FillArrayRandom(numberX, numberY, numberZ);
Console.WriteLine();
PrintMatrix(newArr3D);