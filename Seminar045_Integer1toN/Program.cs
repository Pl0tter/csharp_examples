// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void RowRecursionVoid(int N)
{
    if (N == 1) Console.Write(N + " ");
    else
    {
        RowRecursionVoid(N - 1);
        Console.Write(N + " ");
    }
}

string RowRecursion(int N)
{
    if (N == 1) return $"{N} ";
    else return RowRecursion(N - 1) + $"{N} ";
}

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
RowRecursionVoid(n);
Console.WriteLine();
Console.WriteLine(RowRecursion(n));