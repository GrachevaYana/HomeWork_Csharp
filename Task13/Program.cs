Console.WriteLine("Привет, дорогой друг!");
Console.WriteLine("Напиcали программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine("Примеры: 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6. Давай проверим?");
int Read(string text) //Функция, которая принимает значения от пользователя, пишет текст в консоль, меняет тип данных введенных пользователем на int
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());//можно заменить на int.Parse
}
int ThirdSymbol(int a, int b)// Функция, принимает число и количество символов, выводит третью цифру числа. Если 3 цифры нет, сообщает и выводит 0.
{
    int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет.");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
    return result;
}
int number = Read("Введи число: ");//запрашиваю у пользователя ввод числа
int lengthnumber = number.ToString().Length;//определяю кол-во символов после изм.типа данных на string
Console.Write(ThirdSymbol(number, lengthnumber));
