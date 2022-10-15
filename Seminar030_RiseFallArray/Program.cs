// Задача **: Задан массив чисел. Проверить его значения элементов идут по возрастанию или убыванию

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Console.WriteLine("Получившийся массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 11);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
int countPos = 0;
int countNeg = 0;
for (int i = 0; i < array.Length - 1; i++)
{
    if (array[i] < array[i + 1]) countPos++;
    else if (array[i] == array[i + 1])
    {
        countPos++;
        countNeg++;
    }
    else countNeg++;
}
if (countPos == array.Length - 1) Console.WriteLine("Элементы в массиве возрастают");
else if (countNeg == array.Length - 1) Console.WriteLine("Элементы в массиве убывают");
else Console.WriteLine("Элементы в массиве неупорядочены");