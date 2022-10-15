// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

void findNumber(int[] array, int number)
{
    bool count = false;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] == number) count = true;
    }
    if (count == true) Console.WriteLine("Это число присутствует в массиве");
    else Console.WriteLine("Искомое число отсутствует в массиве");
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число для поиска: ");
int find = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

Console.Write("Исходный массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
findNumber(array, find);