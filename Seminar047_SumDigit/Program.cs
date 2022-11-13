// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumDigit(string number)
{
    int i = number.Length - 1;
    if (i == 0) return Convert.ToInt32(number[i].ToString());
    else return Convert.ToInt32(number[i].ToString()) + SumDigit(number.Remove(i));
}

int SumDigitInt(int number)
{
    if (number < 10) return number;
    else return number % 10 + SumDigitInt(number / 10);
}

Console.Write("Введите число: ");
string numberText = Console.ReadLine();
int number = Convert.ToInt32(numberText);
Console.WriteLine(SumDigit(numberText));
Console.WriteLine(SumDigitInt(number));