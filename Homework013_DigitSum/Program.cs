// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int DigitSum(int a)
{
    int sum = 0;
    int digit = 0;
    while (a > 0)
    {
        digit = a % 10;
        sum = sum + digit;
        a = a / 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма цифр в числе: " + DigitSum(a));