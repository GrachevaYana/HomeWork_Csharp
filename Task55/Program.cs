// Задача 55: Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//В итоге получается вот такой массив:
//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7
//вариант скоппировать первоначальный массив
//и обращаться к нему
int[,] ChangeArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int[,] arrayCopy = new int[rows, cols];
    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < cols; j++)
        arrayCopy[i, j] = array[j, i];
    }
    return arrayCopy;
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
int[,] array = new int[,]
{
        {1,4,7,2},
        {5,9,2,3},
        {8,4,2,4},
        {5,2,6,7}
};
int[,] copyArray = ChangeArray(array);
PrintArray(copyArray);
