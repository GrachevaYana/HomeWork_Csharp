//Задача 57: Составить частотный словарь элементов двумерного массива.
//Частотный словарь содержит информацию о том,
//сколько раз встречается элемент входных данных.
//{ 1, 9, 9, 0, 2, 8, 0, 9 }
//0 встречается 2 раза
//1 встречается 1 раз
//2 встречается 1 раз
//8 встречается 1 раз
//9 встречается 3 раза
//1, 2, 3
//4, 6, 1
//2, 1, 6
//1 встречается 3 раза
//2 встречается 2 раз
//3 встречается 1 раз
//4 встречается 1 раз
//6 встречается 2 раза
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
//Пример. Есть набор данных:
//{ 1, 9, 9, 0, 2, 8, 0, 9 }

//Частотный массив можно представить так:
//0 встречается 2 раза
//1 встречается 1 раз
//2 встречается 1 раз
//8 встречается 1 раз
//9 встречается 3 раза

int[,] ChangeArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    // 5 x4 // 4x 5
    int[,] arrayCopy = new int[cols, rows];
    // 4 x 5 // 5 x 4
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            arrayCopy[j, i] = array[i, j];
        }

    }
    return arrayCopy;
}
void ChangeArray(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);

    int temp = 0;

    for (int i = 0; i < m; i++)
    {
        for (int j = i; j < n; j++)
        {
            temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
}

void FindRepeatElementsInArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int element = array[0, 0];
    int count = 0;
    for (int k = 0; k < rows; k++)
    {
        for (int i = 0; i < cols; i++)
        {
            element = array[k, i];
            for (int m = 0; m < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[m, j] == element)
                    {
                        count++;
                    }
                }
            }
            System.Console.WriteLine($"{array[k, i]} встречается {count}");
            count = 0;

        }
    }

}
int[,] array = new int[,] { {1,4,7,2},
                            {5,9,2,3},
                                    };


FindRepeatElementsInArray(array);


void ChangeArray(int[,] array)
{
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);

    int temp = 0;

    for (int i = 0; i < rows; i++)
    {

        for (int j = i; j < colums; j++)
        {
            (array[i, j], array[j, i]) = (array[j, i], array[i, j]);

            PrintArray(array);
            Console.WriteLine();
        }

    }

}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
int[,] array =
{
    { 1, 2, 3, 4 },
    { 5, 6, 7, 8 },
    { 9, 10, 11, 12 },
    { 13, 14, 15, 16 }
};

ChangeArray(array);
PrintArray(array);


