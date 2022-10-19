// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] fibo = new int[N];
fibo[0] = 0;
fibo[1] = 1;
for (int i = 2; i < fibo.Length; i++)
{
    fibo[i] = fibo[i - 1] + fibo[i - 2];
}
Console.WriteLine($"Первые {N} чисел Фибоначчи: ");
for (int j = 0; j < fibo.Length; j++) Console.Write($"{fibo[j]} ");
Console.WriteLine();