// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string RecNto1String(int Number)
{
    if (Number == 1) return $"{Number}";
    else return $"{Number} " + RecNto1String(Number - 1);
}

void RecNto1Void(int Number)
{
    if (Number == 1) Console.WriteLine(Number);
    else
    {
        Console.Write($"{Number} ");
        RecNto1Void(Number - 1);
    }
}

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(RecNto1String(n));
RecNto1Void(n);