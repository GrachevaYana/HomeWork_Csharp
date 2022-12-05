// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 - > такого числа в массиве нет

int rowsX = ReadLineToInt("Введите индекс строки искомого числа Х: ");
int columsX = ReadLineToInt("Введите индекс столбца искомого числа Х: ");
int[,] array = GetArrayRandom(5, 5);
PrintArray(array);

int[,] GetArrayRandom(int rows, int cols, int minValue = 0, int maxValue = 10)
{
    int[,] array = new int[rows, cols];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue + 1);

        }

    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// Поиск числа в массиве по заданному индексу строки и столбца
if (rowsX < array.GetLength(0) && columsX < array.GetLength(1))
    Console.WriteLine($" Х ( {rowsX};{columsX} ) равен {array[rowsX, columsX]}");
else
    Console.WriteLine($" Х ( {rowsX};{columsX} ) -> такого числа в массиве нет");


// Функция приема данных от пользователем с преобразованием в тип данных int 
int ReadLineToInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}