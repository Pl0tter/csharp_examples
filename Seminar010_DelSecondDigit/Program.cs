// *Задача 11:**
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine("Ваше случайное число: " + number);
int firstDigit = number % 10;
int secondDigit = number / 10 % 10;
int thirdDigit = number / 100;
Console.WriteLine("В нём " + firstDigit + " единиц, " + secondDigit + " десяток, " + thirdDigit + " сотен");

int newnumber = thirdDigit * 10 + firstDigit;

Console.WriteLine("Ваше конечное число: " + newnumber);
Console.WriteLine($"Ваше конечное число: {thirdDigit}{firstDigit}"); // Вариант с интерполяцией строк