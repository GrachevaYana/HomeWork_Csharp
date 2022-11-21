// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

//Функция, которая меняет тип данных введенных пользователем на int
int Read(string text) 
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}
int ArrayLenght = Read("Введите длинну массива: ");

//создаем рандомный массив трехзначных чисел
int[] random_array = new int[ArrayLenght];//
for (int i = 0; i < random_array.Length; i++)
{
    random_array[i] = new Random().Next(100, 1000);
    Console.Write(random_array[i] + " ");
}

//функция подсчета кол-ва четных чисел в массиве
int CountNumber(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count = count+1;
    }
    Console.WriteLine();
    return count;
}
Console.WriteLine(CountNumber(random_array));