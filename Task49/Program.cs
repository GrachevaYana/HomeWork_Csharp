//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
//Например, изначально массив выглядел вот так:
//1 4 7 2
//5 9 2 3
//8 4 2 4
int[,] array = GetArrayRandom(3, 3);
PrintArray(array);
//задаем базовый массив
int[,] GetArrayRandom(int rows, int cols, int minValue = 1, int maxValue = 8)
{
    int[,] array = new int[rows, cols];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue+1);

        }

    }
    return array;
}
//функция вывода на напечать 2 массивов базового и целевого
void PrintArray(int[,] array)
{
    //вывод базового массива
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    //вывод целевого массива
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
            {
                Console.Write(array[i, j] * array[i, j] + "\t");
            }
            else
            {
                Console.Write(array[i, j] + "\t");
            }
                    }
        Console.WriteLine();
    }
}
