// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
if (a > 0)
{
    b = a * -1;
    while (b <= a)
    {
        Console.WriteLine(b);
        b = b + 1;
    }
}
else
{
    b = a * -1;
    while (a <= b)
    {
        Console.WriteLine(a);
        a = a + 1;
    }
}