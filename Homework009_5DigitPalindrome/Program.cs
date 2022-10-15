// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 10000 || number > 99999) Console.WriteLine("Это не пятизначное число");
// else
// {
//     int firstDigit = number % 10;
//     int secondDigit = number / 10 % 10;
//     int fourthDigit = number / 1000 % 10;
//     int fifthDigit = number / 10000;
//     if (firstDigit == fifthDigit && secondDigit == fourthDigit) Console.WriteLine("Число " + number + " палиндром");
//     else Console.WriteLine("Число " + number + " не палиндром");
// }

// =====
// Другие варианты. Разбиение и перенос числа в массив
// =====
// Console.Write("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 10000 || number > 99999) Console.WriteLine("Это не пятизначное число");
// else
// {
//     int i = 0;
//     int[] arrayNumber = new int[5];
//     while (number > 0)
//     {
//         arrayNumber[i] = number % 10;
//         number /= 10;
//         i++;
//     }
//     if (arrayNumber[0] == arrayNumber[4] && arrayNumber[1] == arrayNumber[3]) Console.WriteLine("Число палиндром");
//     else Console.WriteLine("Число не палиндром");
// }

// =====
//Развернуть число в обратном порядке
// =====
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int temp = number;
int result = 0;
while (temp > 0)
{
    result = result * 10 + temp % 10;
    temp /= 10;
}
if (number == result) Console.WriteLine("Число " + number + " палиндром");
else Console.WriteLine("Число " + number + " не палиндром");