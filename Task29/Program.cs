Console.WriteLine("Привет, дорогой друг!");
Console.WriteLine("Напиcали программу, которая задаёт массив из 8 элементов и выводит их на экран.");
Console.WriteLine("Примеры: 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19], 6, 1, 33-> [6, 1, 33]. Давай проверим?");
int Read(string text) //Функция, которая принимает значения от пользователя, пишет текст в консоль, меняет тип данных введенных пользователем на int
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}
int ArrayLenght = Read("Введите длинну массива: ");//запрашиваем у пользователя длину массива
int[] random_array = new int[ArrayLenght];//переменная типа массив
for (int i = 0; i < random_array.Length; i++)//цикл заполнения массива
{
    random_array[i] = new Random().Next(1, 100);//создаем рандомный массив из длины заданной пользователем
    Console.Write(random_array[i] + " ");//вывод массива в консоль
}
