//x1 ^ 5 + x2 ^ 5 + x3 ^ 5 + x4 ^ 5 = x5 ^ 5
// Ограничение любой из x - от 1 до 300
// Нужно перебрать их все.
// Подумать, как лучше это сделать

// Закомментирован вариант с перебором x5.
// Текущий вариант с извлечением корня левой части. Извлечение корня из больших чисел, почему-то всегда возвращает остаток, хотя его не должно быть. Поэтому проверка x5 на +-1 значения корня.

uint length = 300;
// ulong start = 0; // начало для x5
// ulong end = 0; // конец для x5
ulong sum = 0;
uint sumRoot = 0;

for (ulong a = 1; a <= length; a++)
{
    for (ulong b = a; b <= length; b++)
    {
        for (ulong c = b; c <= length; c++)
        {
            for (ulong d = c; d <= length; d++)
            {
                // if (a > b && a > c && a > d) end = Convert.ToUInt64(a * 1.32); // a * 4^(1/5)
                // if (b > a && b > c && b > d) end = Convert.ToUInt64(b * 1.32);
                // if (c > a && c > b && c > d) end = Convert.ToUInt64(c * 1.32);
                // if (d > a && d > b && d > c) end = Convert.ToUInt64(d * 1.32);
                // start = Convert.ToUInt64(a * 1.32);
                // for (ulong e = start; e <= end; e++)
                // {
                //     if ((a * a * a * a * a) + (b * b * b * b * b) + (c * c * c * c * c) + (d * d * d * d * d) == (e * e * e * e * e))
                //     {
                //         Console.WriteLine(a + " " + b + " " + c + " " + d + " " + e);
                //     }
                // }
                sum = (a * a * a * a * a) + (b * b * b * b * b) + (c * c * c * c * c) + (d * d * d * d * d);
                sumRoot = Convert.ToUInt32(Math.Pow(sum, 0.2));
                for (ulong e = sumRoot - 1; e <= sumRoot + 1; e++)
                {
                    if (sum == (e * e * e * e * e)) Console.WriteLine(a + " " + b + " " + c + " " + d + " " + e);
                }
            }
        }
    }
}

// Результаты:
// x1   x2  x3  x4  x5
// 27   84  110 133 144
// 54   168 220 266 288