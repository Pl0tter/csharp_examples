Console.Clear();
Console.Write("Какой день недели: ");
int x = Convert.ToInt32(Console.ReadLine());
string d1 = "Понедельник";
string d2 = "Вторник";
string d3 = "Среда";
string d4 = "Четверг";
string d5 = "Пятница";
string d6 = "Суббота";
string d7 = "Воскресенье";

 if (x == 1)
 {
    Console.WriteLine(d1);
 }
  if (x == 2)
 {
    Console.WriteLine(d2);
 }
   if (x == 3)
 {
    Console.WriteLine(d3);
 }
   if (x == 4)
 {
    Console.WriteLine(d4);
 }
   if (x == 5)
 {
    Console.WriteLine(d5);
 }
   if (x == 6)
 {
    Console.WriteLine(d6);
 }
   if (x == 7)
 {
    Console.WriteLine(d7);
 }