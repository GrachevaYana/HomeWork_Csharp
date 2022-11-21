// Задача 53: Задайте двумерный массив.
// Напишите программу, которая поменяет
// местами первую и последнюю строку массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//8 4 2 4
//5 9 2 3
//1 4 7 2

int[,] ChangeArray(int[,] array)
{
    int temp;
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < cols; i++)
    { 
        temp = array[0,i];
        array[0,i] = array[rows - 1, i];
        array[rows - 1, i] = temp;
    }
    return array;
}
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ "\t");
        }
        Console.WriteLine();
    }
}
int[,] array = new int[,]
{
        {1,4,7,2},
        {5,9,2,3},
        {8,4,2,4}
};
ChangeArray(array);
PrintArray(array);



