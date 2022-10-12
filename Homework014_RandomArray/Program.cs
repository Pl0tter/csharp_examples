// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] massif)
{
    int length = massif.Length;
    string[] massifText = new string[length];
    Console.Write("Введите элементы массива через ', ': ");
    massifText = Console.ReadLine().Split(", ");
    for (int i = 0; i < massif.Length; i++) massif[i] = Convert.ToInt32(massifText[i]);
}

string PrintArray(int[] massif)
{
    int length = massif.Length;
    string result = "[";
    for (int i = 0; i < length; i++)
    {
        if (i < length - 1) result = result + $"{massif[i]}, ";
        else result = result + massif[i];
    }
    return result = result + "]";
}
Console.Write("Введите размерность одномерного массива: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = new int[x];
FillArray(array);
string result = PrintArray(array);
Console.WriteLine(result);