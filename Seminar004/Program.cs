Console.Clear();
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = 0;
if (x > 0)
{
    y = x * -1;
    while (y <= x)
    {
        Console.WriteLine(y);
        y = y + 1;
    }
}
else
{
    y = x * -1;
    while (x <= y)
    {
        Console.WriteLine(x);
        x = x + 1;
    }
}