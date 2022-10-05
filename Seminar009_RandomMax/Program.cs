// Определить в случайном двухзначном числе какая из цифр больше
int number = new Random().Next(10, 100);
Console.WriteLine("Ваше случайное число " + number);
int firstDigit = number % 10;
int secondDigit = number / 10;
Console.WriteLine("В нём " + firstDigit + " единиц и " + secondDigit + " десяток");

if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit + " больше " + secondDigit);
}
else if (firstDigit < secondDigit)
{
    Console.WriteLine(firstDigit + " меньше " + secondDigit);
}
else
{
    Console.WriteLine(firstDigit + " равно " + secondDigit);
}