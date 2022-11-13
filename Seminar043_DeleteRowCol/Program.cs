// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(0, 10);
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

int[,] DeleteRowCol(int[,] array, int row, int col)
{
    int[,] arrayDel = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int a = 0; a < array.GetLength(0); a++)
    {
        if (a != row)
        {
            for (int b = 0; b < array.GetLength(1); b++)
            {
                if (b != col) arrayDel[m, n++] = array[a, b];
            }
            n = 0;
            m++;
        }
    }
    return arrayDel;
}

int[] FindMinRowCol(int[,] array)
{
    int[] arrayMinRowCol = new int[3];
    arrayMinRowCol[0] = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < arrayMinRowCol[0])
            {
                arrayMinRowCol[0] = array[i, j];
                arrayMinRowCol[1] = i;
                arrayMinRowCol[2] = j;
            }
        }
    }
    return arrayMinRowCol;
}

// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[6, 6];

FillArray(array);
PrintArray(array);
int[] result = new int[3];
result = FindMinRowCol(array);
int[,] arrayNew = DeleteRowCol(array, result[1], result[2]);
PrintArray(arrayNew);