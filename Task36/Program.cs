//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6]-> 0

//Функция, которая меняет тип данных введенных пользователем на int
int Read(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}
int ArrayLenght = Read("Введите длинну массива: ");

//создаем рандомный чисел
int[] random_array = new int[ArrayLenght];//
for (int i = 0; i < random_array.Length; i++)
{
    random_array[i] = new Random().Next(-10, 10);
    Console.Write(random_array[i] + " ");
}

//функция подсчета кол-ва четных чисел в массиве
int SumOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        sum = array[i] + sum;
    }
    Console.WriteLine();
    return sum;
}
Console.WriteLine(SumOddPosition(random_array));