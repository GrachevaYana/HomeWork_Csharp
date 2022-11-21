//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

//Функция, которая меняет тип данных введенных пользователем на int
int Read(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}
int ArrayLenght = Read("Введите длинну массива: ");

//создаем рандомный массив чисел
int[] random_array = new int[ArrayLenght];
for (int i = 0; i < random_array.Length; i++)
{
    random_array[i] = new Random().Next(0, 100);
    Console.Write(random_array[i] + " ");
}

//функция определения максимального числа в массиве
int MaxNumber(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    Console.WriteLine();
    return max;
}

//функция определения минимального числа в массиве
int MinNumber(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    Console.WriteLine();
    return min;
}
Console.WriteLine(MaxNumber(random_array)- MinNumber(random_array));

