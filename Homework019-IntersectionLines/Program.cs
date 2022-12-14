// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите b1: ");
float b1 = Convert.ToSingle(Console.ReadLine());
Console.Write("Введите k1: ");
float k1 = Convert.ToSingle(Console.ReadLine());
Console.Write("Введите b2: ");
float b2 = Convert.ToSingle(Console.ReadLine());
Console.Write("Введите k2: ");
float k2 = Convert.ToSingle(Console.ReadLine());

if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
else if (k1 == k2) Console.WriteLine("Прямые параллельны");
else
{
    float x = (b2 - b1) / (k1 - k2);
    if (x == -0) x = 0;
    float y = k1 * x + b1;
    Console.WriteLine("Точка пересечения: " + x + "; " + y);
}