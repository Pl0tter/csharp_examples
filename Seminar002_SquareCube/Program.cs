Console.Clear();
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Квадрат или куб: ");
int y = Convert.ToInt32(Console.ReadLine());
if (y == 2)
{
    x = x * x;
    Console.WriteLine("Квадрат числа: " + x);
}
else
{
    x = x * x * x;
    Console.WriteLine("Куб числа: " + x);
}