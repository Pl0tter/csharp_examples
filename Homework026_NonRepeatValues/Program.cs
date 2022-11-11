// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void Fill3DArray(int[,,] collection, int first, int last)
{
    int temp = 0;
    bool uniq;
    int count = 0;
    int[] dict = new int[collection.GetLength(0) * collection.GetLength(1) * collection.GetLength(2)];
    dict[0] = new Random().Next(first, last);
    for (int i = 1; i < dict.Length; i++)
    {
        uniq = false;
        while (uniq == false)
        {
            temp = new Random().Next(first, last);
            for (int j = 0; j < i; j++)
            {
                if (temp == dict[j]) count++;
            }
            if (count == 0) uniq = true;
            count = 0;
        }
        dict[i] = temp;
    }
    int index = 0;
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            for (int k = 0; k < collection.GetLength(2); k++)
            {
                collection[i, j, k] = dict[index++];
            }
        }
    }
}
void Print3DArray(int[,,] collection)
{
    for (int i = 0; i < collection.GetLength(2); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            for (int k = 0; k < collection.GetLength(0); k++)
            {
                Console.Write($"{collection[j, k, i]}({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] array = new int[2, 2, 2];
Fill3DArray(array, 10, 20);
Print3DArray(array);