// У нас есть график, где даны отрезок 1 -  (х1; x2) и отрезок 2 (х3, x4)
// ​Необходимо составить код, который находит их пересечение.
// Пересечением двух отрезка 1 и 2 могут быть  - отрезок, точка или ничего
// С клавиатуры вводим х1, x2, х3, x4 и выводим ответ - границы пересечений отрезков, общую точку или «не пересекаются».

Console.Write("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x3: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x4: ");
int x4 = Convert.ToInt32(Console.ReadLine());

if (x3 > x1 && x3 < x2) // x1 - x3 - x2 
{
    if (x4 > x1 && x4 < x2) // x1 - x4 - x2
    {
        Console.WriteLine("Пересечение - отрезок (" + x3 + "; " + x4 + ")");
    }
    else
    {
        Console.WriteLine("Пересечение - отрезок (" + x3 + "; " + x2 + ")");
    }
}
else if (x4 > x1 && x4 < x2)
{
    Console.WriteLine("Пересечение - отрезок (" + x1 + "; " + x4 + ")");
}
else if (x2 == x3)
{
    Console.WriteLine("Пересечение - точка " + x2);
}
else if (x1 == x4)
{
    Console.WriteLine("Пересечение - точка " + x1);
}
else
{
    Console.WriteLine("Отрезки не пересекаются");
}