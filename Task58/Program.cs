//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

using System;

int rows = 2;
int columns = 2;
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

ArrayRandom(array);
PrintArray2D(array);

Console.WriteLine();

ArrayRandom(secondArray);
PrintArray2D(secondArray);

Console.WriteLine();

PrintArray2D(resultArray);

Console.WriteLine();

void PrintArray2D(int[,] array);
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            resultArray[i, j] = 0;
            for (int k = 0; k < array.GetLength(1); k++)
            {
                resultArray[i, j] += array[i, k] * secondArray[k, j];
                PrintArray2D(resultArray);
            }
        }
    }
}


// Функция заполнения массива рандомными числами от 1 до 5
void ArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 6);
        }
    }
}
