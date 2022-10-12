//====Методы====

// Ничего не принимает и ничего не возвращает
void SayHello()
{
    Console.WriteLine("Hello, C#!");
}

// Принимает аргументы, но ничего не возвращает 
void SayHelloLanguage(string lang)
{
    Console.WriteLine($"Hello, {lang}!");
}

SayHello();
SayHelloLanguage("Python");
SayHelloLanguage("C++");
// Принимает аргументы, но ничего не возвращает 
void MinMax(int x, int y)
{
    if (x > y) Console.WriteLine(x);
    else Console.WriteLine(y);
}

MinMax(3, 5);

// Принимает и возвращает (return) аргументы
int Middle(int x, int y)
{
    int result = (x + y) / 2;
    return result;
}

int c = Middle(3, 5);
Console.WriteLine(c);