// Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] collection, int first, int last)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++) collection[i, j] = new Random().Next(first, last);
    }
}
void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++) Console.Write(collection[i, j] + " ");
        Console.WriteLine();
    }
}
int MinRow(int[,] collection)
{
    int sum = 0;
    int min = 0;
    int minRow = 0;
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++) sum += collection[i, j];

        if (i == 0 || sum < min)
        {
            min = sum;
            minRow = i + 1;
        }
        sum = 0;
    }
    return minRow;
}

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array, 0, 10);
PrintArray(array);
Console.WriteLine("Строка с наименьшей суммой элементов: " + MinRow(array));