﻿// **Задача 12:** 
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a % b == 0)
{
    Console.WriteLine(a + " кратно " + b);
}
else
{
    int rest = a % b;
    Console.WriteLine(a + " некратно " + b + ". Остаток от деления равен: " + rest);
}