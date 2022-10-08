// Задача 17: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());

// if (x>0)
// {
//     if (y>0) Console.WriteLine("Точка (" + x + "; " + y + ") лежит в I четверти");
//     else Console.WriteLine("Точка (" + x + "; " + y + ") лежит в IV четверти");
// }
// else
// {
//     if (y>0) Console.WriteLine("Точка (" + x + "; " + y + ") лежит в II четверти");
//     else Console.WriteLine("Точка (" + x + "; " + y + ") лежит в III четверти");
// }
if (x==0 && y==0) Console.WriteLine("Точка (" + x + "; " + y + ") начало координат");
if (x>0 && y>0) Console.WriteLine("Точка (" + x + "; " + y + ") лежит в I четверти");
if (x<0 && y>0) Console.WriteLine("Точка (" + x + "; " + y + ") лежит в II четверти");
if (x<0 && y<0) Console.WriteLine("Точка (" + x + "; " + y + ") лежит в III четверти");
if (x>0 && y<0) Console.WriteLine("Точка (" + x + "; " + y + ") лежит в IV четверти");