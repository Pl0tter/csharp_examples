// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string[] arrayText;
int count = 0;
Console.WriteLine("Введите числа через пробел:");
arrayText = Console.ReadLine().Split(" ");

for (int i = 0; i < arrayText.Length; i++)
{
    if (Convert.ToInt32(arrayText[i])>0) count++;
}
Console.WriteLine($"Количество чисел больше нуля: {count}");