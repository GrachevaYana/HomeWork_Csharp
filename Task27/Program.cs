Console.WriteLine("Привет, дорогой друг!");
Console.WriteLine("Напиcали программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine("Примеры: 452 -> 11, 82 -> 10, 9012 -> 12. Давай проверим?");
int Read(string text) //Функция, которая принимает значения от пользователя, пишет текст в консоль, меняет тип данных введенных пользователем на int
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}
int NumberLenght(int a)// Функция, которая ведет подсчет кол-ва цифр в числе
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}
void SumDigits(int n, int len)// Функция выводит сумму цифр в числе
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"Сумма цифр в числе равна: {sum}.");
}
int number = Read("Введите число: ");
int lenght = NumberLenght(number);
SumDigits(number, lenght);