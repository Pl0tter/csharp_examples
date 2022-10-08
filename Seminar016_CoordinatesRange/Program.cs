// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите четверть декартовой ситемы координат: ");
int quad = Convert.ToInt32(Console.ReadLine());
if (quad < 1 || quad > 4) Console.WriteLine("Такой четверти не существует");
if (quad == 1) Console.WriteLine("Диапазон координат от (0; 0) до (" + int.MaxValue + "; " + int.MaxValue + ")");
if (quad == 2) Console.WriteLine("Диапазон координат от (0; 0) до (" + -int.MaxValue + "; " + int.MaxValue + ")");
if (quad == 3) Console.WriteLine("Диапазон координат от (0; 0) до (" + -int.MaxValue + "; " + -int.MaxValue + ")");
if (quad == 4) Console.WriteLine("Диапазон координат от (0; 0) до (" + int.MaxValue + "; " + -int.MaxValue + ")");