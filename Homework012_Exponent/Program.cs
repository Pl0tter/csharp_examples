// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponent(int a, int b)
{
    int product = 1;
    for (int i = 0; i < b; i++) product = product * a;
    return product;
}

Console.Write("Введите основание степени: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите показатель степени: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Результат равен: " + Exponent(a, b));