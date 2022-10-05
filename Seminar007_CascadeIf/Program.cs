// Каскадные условия
int age = 10;
string gender = "male";

if (age >= 20)
{
    Console.WriteLine("Hello, old!");
}
else if (age >= 10)
{
    Console.WriteLine("Hello, young!");
}
else
{
    Console.WriteLine("Hello, baby!");
}

if (age < 20 && gender == "male") // Условие && (and) когда выполняются оба условия
{
    Console.WriteLine("Hello, dude!");
}

if (age < 10 || gender == "female") // Условие || (or) когда выполняются хотя бы одно условие
{
    Console.WriteLine("Hello, girl!");
}