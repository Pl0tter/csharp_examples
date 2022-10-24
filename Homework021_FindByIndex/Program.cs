// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

string findNumber(int[,] array, int row, int col)
{
    if (row < 0 || row >= array.GetLength(0) || col < 0 || col >= array.GetLength(1)) return "отсутствует";
    else return Convert.ToString(array[row, col]);
}

int[,] array = new int[3, 4];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите позицию по вертикали элемента: ");
int row = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите позицию по горизонтали элемента: ");
int col = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine($"Искомый элемент: {findNumber(array, row, col)}");