// Задача 13: Напишите программу, которая выводит третью цифру СЛЕВА заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 3267912 -> 6

Console.Write("Введите число: ");
long number = Convert.ToInt64(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("Нет третьей цифры в " + number);
}
else
{
    long i = 100;
    while (number >= i)
    {
        i = i * 10;
    }
    Console.WriteLine($"Третья цифра слева: {number / (i / 1000) % 10}");
}