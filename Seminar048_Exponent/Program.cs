// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Exp(int a, int b)
{
    if (b == 1) return a;
    else return a * Exp(a, b - 1);
}
Console.Write("Введите основание степени A: ");
int a = Convert.ToInt32(Console.ReadLine());;
Console.Write("Введите показатель степени B: ");
int b = Convert.ToInt32(Console.ReadLine());;
Console.WriteLine(Exp(a, b));