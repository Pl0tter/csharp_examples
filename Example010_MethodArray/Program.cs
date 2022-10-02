int[] array = {1, 12, 31, 4, 18, 15, 16, 17, 18};

int n = array.Length; // определение длины массива
int find = 18;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; //прерывание цикла, чтобы не искать второй одинаковый элемент
    }
    // index = index + 1; - тоже самое что ниже
    index++;
}