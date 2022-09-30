Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Последнее число: {number % 10}");