Console.Clear();
Console.WriteLine("Hello, World!");
string name = "Vladimir!";
Console.WriteLine("Hello, " + name); // Метод конкатенации строки (склеивания). Совмещение переменных через +
Console.Write($"Введите число, {name}: "); // Метод интерполяции строки. Совмещение переменных через $ и {}
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы набрали: {num}");