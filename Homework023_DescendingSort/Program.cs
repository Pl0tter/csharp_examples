// Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
void DescendingSort(int[,] collection)
{
    int temp;
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int pass = 1; pass <= collection.GetLength(1) - 1; pass++)
        {
            for (int j = 0; j < collection.GetLength(1) - pass; j++)
            {
                if (collection[i, j] < collection[i, j + 1])
                {
                    temp = collection[i, j];
                    collection[i, j] = collection[i, j + 1];
                    collection[i, j + 1] = temp;
                }
            }
        }

    }
}

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array, 0, 10);
PrintArray(array);
Console.WriteLine();
DescendingSort(array);
PrintArray(array);