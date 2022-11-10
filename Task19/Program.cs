Console.WriteLine("Привет, дорогой друг!");
Console.WriteLine("Напиcали программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.WriteLine("Примеры: 14212 -> нет, 12821 -> да, 23432 -> да. Давай проверим?");
int Read(string text) //Функция, которая принимает значения от пользователя, пишет текст в консоль, меняет тип данных введенных пользователем на int
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}
int ConvertWithSize(int value, int size)// функция, которая преобразует число в массив и проверяет является ли число палиндромом
{
    int[] digits = new int[size];
    for (int index = size - 1; index >= 0; index--)
    {
        digits[index] = value % 10;
        value = value / 10;
    }
    int res = 0;
    if (digits[0] == digits[4] && digits[1] == digits[3])
    {
        Console.Write("Введенное число является палиндромом: ");
        res = 1;
    }
    else
    {
        Console.Write("Введенное число не является палиндромом: ");
        res = 0;
    }
    return res;
}
int number = Read("Введи 5-значное число: ");//запрашиваю у пользователя ввод числа
int lengthnumber = number.ToString().Length;//определяю кол-во символов после изм.типа данных на string
Console.WriteLine(ConvertWithSize(number, lengthnumber));

