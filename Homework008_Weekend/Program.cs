// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
{
    Console.WriteLine("Такого дня недели не существует");
}
else if (number == 6 || number == 7)
{
    Console.WriteLine("Это выходной день");
}
else
{
    Console.WriteLine("Это будний день");
}