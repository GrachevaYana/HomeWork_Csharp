Console.WriteLine("Привет, дорогой друг!");
Console.WriteLine("Напиcали программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.WriteLine("Примеры: 5 -> 243 (3⁵), 2, 4 -> 16. Давай проверим?");
int Read(string text) //Функция, которая принимает значения от пользователя, пишет текст в консоль, меняет тип данных введенных пользователем на int
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}
void Degree(int a, int b)//функция возведения числа А в степень В
{
    int result = 1;
    int i = 1;
    while (i <= b)
    {
        result = result * a;
        i++;
        //Console.WriteLine(result);- выводит в столбик начения возведения числа сначала в степень 1, затем 2 и т.д. до В.
    }
    Console.WriteLine(result);// выводит возведение числа в степень.
}
int numberA = Read("Введи первое число A: ");//запрашиваю у пользователя ввод числа
int numberB = Read("Введи второе число B: ");//запрашиваю у пользователя ввод числа
Degree(numberA, numberB);
