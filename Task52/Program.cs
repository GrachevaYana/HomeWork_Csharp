//Задача 52. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[4, 5];
CreateArray(array);
PrintArray2D(array);

double[] Average = new double[array.GetLength(1)];

for (int i = 0; i < array.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        result += array[j, i];
    }
    Average[i] = result / array.GetLength(0);
}
PrintArray(Average);


// Заполнение массива числами от 0 до 100
void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
}

//  Функция вывода двумерного массива в терминал
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Функция
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; ");
    }
    Console.WriteLine();
}
