﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double ColAvg(int[,] array, int col)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++) sum += array[i, col];
    return Math.Round(sum / array.GetLength(0), 1);
}

int[,] array = new int[3, 4];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.Write("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < array.GetLength(1); j++) Console.Write(ColAvg(array, j) + " ");
Console.WriteLine();