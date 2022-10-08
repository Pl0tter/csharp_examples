// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 10000 || number > 99999) Console.WriteLine("Это не пятизначное число");
else
{
    int firstDigit = number % 10;
    int secondDigit = number / 10 % 10;
    int fourthDigit = number / 1000 % 10;
    int fifthDigit = number / 10000;
    if (firstDigit == fifthDigit && secondDigit == fourthDigit) Console.WriteLine("Число " + number + " палиндром");
    else Console.WriteLine("Число " + number + " не палиндром");
}