// **Задача 16:**
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a * a == b)
{
    Console.WriteLine(a + " в квадрате равно " + b);
}
else if (b * b == a)
{
    Console.WriteLine(b + " в квадрате равно " + a);
}
else
{
    Console.WriteLine(a + " и " + b + " не являются квадратом друг друга");
}