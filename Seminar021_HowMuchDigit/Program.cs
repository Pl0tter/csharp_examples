// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int HowMuchDigit(int A)
{
    int count = 0;
    while (A > 0)
    {
        A = A / 10;
        count++;
    }
    return count;
}

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"В числе {A} {HowMuchDigit(A)} цифр");