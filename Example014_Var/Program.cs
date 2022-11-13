using System.Linq; //подключение системной библиотеки
var a = 12; // поскольку явно заявлено целое число 12, то переменная var определяется как int
Console.WriteLine(a.GetType()); // выводит тип переменной. GetType().Name - убираете в выводе вначале System

var data = new int[] { 1, 2, 3, 4 }
            .Where(e => e > 0)
            .Select(e => new { q = e, w = e + 1 });
Console.WriteLine(data.GetType().Name);
Console.WriteLine(data.GetType());