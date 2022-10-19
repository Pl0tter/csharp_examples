// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.Write("Введите размер массива: ");
int l = Convert.ToInt32(Console.ReadLine());
int[] array = new int[l];
int[] arrayCopy = new int[l];

Console.WriteLine("Исходный массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

Console.WriteLine("Копия массива: ");
for (int j = 0; j < array.Length; j++)
{
    arrayCopy[j] = array[j];
    Console.Write($"{arrayCopy[j]} ");
}
Console.WriteLine();