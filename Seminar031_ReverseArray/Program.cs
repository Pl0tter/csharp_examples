// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.Write("Введите размер массива: ");
int l = Convert.ToInt32(Console.ReadLine());
int[] array = new int[l];
int temp = 0;
Console.WriteLine("Исходный массив: ");
for (int j = 0; j < array.Length; j++)
{
    array[j] = new Random().Next(0, 10);
    Console.Write($"{array[j]} ");
}
Console.WriteLine();

for (int i = 0; i < array.Length / 2; i++)
{
    temp = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temp;
}
Console.WriteLine("Развернутый массив: ");
for (int j = 0; j < array.Length; j++) Console.Write($"{array[j]} ");
Console.WriteLine();