// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

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

void CountElements(int[,] array)
{
    List<int> dict = new List<int> { };
    List<int> freq = new List<int> { };
    bool existDict = false;
    int count = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < dict.Count; l++) if (array[i, j] == dict[l]) existDict |= true;
            if (existDict == false)
            {
                dict.Add(array[i, j]);
                for (int a = 0; a < array.GetLength(0); a++)
                {
                    for (int b = 0; b < array.GetLength(1); b++) if (array[a, b] == dict.Last()) count++;
                }
                freq.Add(count);
                count = 0;
            }
            existDict = false;
        }
    }

    int[,] dictArray = new int[dict.Count, 2];
    for (int h = 0; h < dictArray.GetLength(0); h++)
    {
        dictArray[h, 0] = dict[h];
        dictArray[h, 1] = freq[h];
    }
    int temp0 = 0;
    int temp1 = 0;
    for (int pass = 0; pass < dictArray.GetLength(0) - 1; pass++)
    {
        for (int f = 0; f < dictArray.GetLength(0) - 1 - pass; f++)
        {
            if (dictArray[f, 0] > dictArray[f + 1, 0])
            {
                temp0 = dictArray[f, 0];
                temp1 = dictArray[f, 1];
                dictArray[f, 0] = dictArray[f + 1, 0];
                dictArray[f, 1] = dictArray[f + 1, 1];
                dictArray[f + 1, 0] = temp0;
                dictArray[f + 1, 1] = temp1;
            }
        }
    }
    for (int p = 0; p < dictArray.GetLength(0); p++)
    {
        Console.WriteLine($"{dictArray[p, 0]} встречается {dictArray[p, 1]} раз");
    }
}

// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[5, 10];

FillArray(array);
PrintArray(array);
CountElements(array);