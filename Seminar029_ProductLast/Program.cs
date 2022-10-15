// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Console.WriteLine("Начальный массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 11);
    if (i != array.Length - 1) Console.Write($"{array[i]}, "); // вывод массива
    else Console.WriteLine($"{array[i]}");
}
int[] newArray = new int[size / 2 + size % 2];
Console.WriteLine("Новый массив: ");
for (int i = 0; i < newArray.Length; i++)
{
    if (array.Length - 1 - i == i) newArray[i] = array[i]; // при нечетном количестве не меняем элемент по середине
    else newArray[i] = array[i] * array[array.Length - 1 - i];
    if (i != newArray.Length - 1) Console.Write($"{newArray[i]}, "); // вывод массива
    else Console.WriteLine($"{newArray[i]}");
}