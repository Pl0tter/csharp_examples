﻿// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void PrintArray(int[] Massif)
{
    for (int i = 0; i < Massif.Length; i++)
    {
        Console.Write(Massif[i] + " ");
    }
    Console.WriteLine();
}

void ArrayRandom(int[] Massif)
{
    for (int i = 0; i < Massif.Length; i++)
    {
        Massif[i] = new Random().Next(0,2);
    }
}

int[] Array = new int[8];
PrintArray(Array);
ArrayRandom(Array);
PrintArray(Array);