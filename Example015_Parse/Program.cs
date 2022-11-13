using System.Linq;

string text = "(1,2) (2,3) (4,5) (9,7)"
            .Replace("(", "")
            .Replace(")", "");
Console.WriteLine(text);
var data = text.Split(" ")
            .Select(item => item.Split(',')) // разбивает каждый элемент массива на массив
            .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) // превращает встроенный массив в кортеж чисел с присвоением имени для первого числа x, а для второго y
            .Where(e => e.x % 2 == 0)
            .Select(point => (point.x * 10, point.y))
            .ToArray(); // превращение в массив

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);

    //Console.WriteLine(data[i].x * 10);

    // for (int k = 0; k < data[i].Length; k++) // нужно оставить если не превращаем в кортеж чисел, а предыдущую строчку отключить
    // {
    //     Console.WriteLine(data[i][k]);
    // }
    //Console.WriteLine();
}