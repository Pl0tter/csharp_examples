// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void RotateArray(int[,] collection)
{
    int temp = 0;
    int yMax = collection.GetLength(0) - 1;
    int xMax = collection.GetLength(1) - 1;

    for (int i = 0; i < collection.GetLength(0) / 2; i++)
    {
        for (int j = i + 0; j < collection.GetLength(1) - 1 - i; j++)
        {
            temp = collection[i, j];
            collection[i, j] = collection[j, xMax - i];
            collection[j, xMax - i] = collection[yMax - i, xMax - j];
            collection[yMax - i, xMax - j] = collection[yMax - j, i];
            collection[yMax - j, i] = temp;
        }
    }
}
void SpiralFillArray(int[,] collection)
{
    int count = 10;
    for (int i = 0; i < collection.GetLength(0) / 2; i++)
    {
        for (int side = 0; side < 4; side++)
        {
            for (int j = 0 + i; j < collection.GetLength(1) - 1 - i; j++)
            {
                collection[i, j] = count++;
            }
            RotateArray(collection);
        }
    }
    if (collection.GetLength(0) % 2 != 0) collection[collection.GetLength(0) / 2, collection.GetLength(0) / 2] = count++;
}
void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++) Console.Write(collection[i, j] + " ");
        Console.WriteLine();
    }
}

int[,] array = new int[5, 5];
SpiralFillArray(array);
PrintArray(array);