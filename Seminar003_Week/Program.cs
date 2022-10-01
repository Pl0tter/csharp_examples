//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница
Console.Clear();
Console.Write("Какой день недели: ");
int x = Convert.ToInt32(Console.ReadLine());

 if (x == 1)
 {
    Console.WriteLine("Это понедельник");
 }
  if (x == 2)
 {
    Console.WriteLine("Это вторник");
 }
   if (x == 3)
 {
    Console.WriteLine("Это среда");
 }
   if (x == 4)
 {
    Console.WriteLine("Это четверг");
 }
   if (x == 5)
 {
    Console.WriteLine("Это пятница");
 }
   if (x == 6)
 {
    Console.WriteLine("Это суббота");
 }
   if (x == 7)
 {
    Console.WriteLine("Это воскресенье");
 }