Console.Clear();
Console.WriteLine("Hello, World!");
string name = "Vladimir!";
Console.WriteLine("Hello, " + name); // Метод конкатенации. Совмещение переменных
Console.Write($"Введите число, {name}: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы набрали: {num}");