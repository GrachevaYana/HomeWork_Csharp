Console.WriteLine("Привет, дорогой друг!");
Console.WriteLine("Напиcали программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
Console.WriteLine("Примеры: 3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125. Давай проверим?");
int Read(string text) //Функция, которая принимает значения от пользователя, пишет текст в консоль, меняет тип данных введенных пользователем на int
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}
int number = Read("Введи число N: ");//запрашиваю у пользователя ввод числа
void Kub(int a)//функция возведения числа А в 3 степень
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write($"{i * i * i}  ");
    }
}
Kub(number);