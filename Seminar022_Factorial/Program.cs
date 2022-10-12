// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Factorial(int N)
{
    int prod = 1;
    for (int i = 1; i <= N; i++)
    {
        prod = prod * i;
    }
    return prod;
}

Console.Write("Введите число :");
int N = Convert.ToInt32(Console.ReadLine());
int prod = Factorial(N);
Console.WriteLine($"Факториал числа {N} равен {prod}");