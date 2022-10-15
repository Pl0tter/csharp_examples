// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int sum = 0;
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 11);
    Console.Write(array[i] + " ");
    if (i % 2 != 0) sum = sum + array[i];
}
Console.WriteLine();
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + sum);