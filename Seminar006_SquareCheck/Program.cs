﻿// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
Console.Clear();
Console.Write("Введите квадратный корень числа: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

if (y == x * x)
{
    Console.WriteLine("Верно");
}
else
{
    Console.WriteLine("Неверно");
}