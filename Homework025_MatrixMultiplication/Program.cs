// Задача 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillArray(int[,] collection, int first, int last)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++) collection[i, j] = new Random().Next(first, last);
    }
}
void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++) Console.Write(collection[i, j] + " ");
        Console.WriteLine();
    }
}
int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            for (int r = 0; r < matrixA.GetLength(1); r++) matrixC[i, j] += matrixA[i, r] * matrixB[r, j];
        }
    }
    return matrixC;
}

int[,] matrixA = new int[2, 2];
int[,] matrixB = new int[2, 2];
FillArray(matrixA, 0, 10);
FillArray(matrixB, 0, 10);
PrintArray(matrixA);
Console.WriteLine();
PrintArray(matrixB);
Console.WriteLine();

if (matrixA.GetLength(1) == matrixB.GetLength(0)) PrintArray(MatrixMultiplication(matrixA, matrixB));
else Console.WriteLine("Матрицы не совместимы. Произведение не возможно.");