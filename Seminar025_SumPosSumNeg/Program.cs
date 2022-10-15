// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] array = new int[12];
int sumPos = 0;
int sumNeg = 0;
Console.WriteLine("Массив из 12 элементов:");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write(array[i] + " ");
    if (array[i] > 0) sumPos = sumPos + array[i];
    else sumNeg = sumNeg + array[i];
}

Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов равна: {sumPos}");
Console.WriteLine($"Сумма отрицательных элементов равна: {sumNeg}");