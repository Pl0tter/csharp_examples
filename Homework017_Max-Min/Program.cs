// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int MaxMin(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    int subtraction = max - min;
    return subtraction;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 21);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным элементом: " + MaxMin(array));