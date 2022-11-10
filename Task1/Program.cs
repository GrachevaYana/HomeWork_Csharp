// See https://aka.ms/new-console-template for more information
Console.WriteLine("Привет, дорогой друг!");
Console.WriteLine("Напиcали программу, которая принимает на вход 3-хзначное число и на выходе показывает последнюю цифру этого числа");
Console.WriteLine("Примеры: 456 -> 6, 589 ->9. Давай проверим?");
int GetLastDigit(int num) //объявление функции
{
    int LastDigit = num % 10;//сохраняем расчет в переменную либо можно запихнуть расчет в return
    return LastDigit;
}
Console.WriteLine("Введи любое 3-хзначное число: ");
int num = int.Parse(Console.ReadLine()!); //задаем значение цисла, в котом нужно узнать последнюю цифру
int lastdigit = GetLastDigit(num);//записываем результат выполнения функции
Console.WriteLine($"Последняя цифра 3-хзначного числа {num} равна {lastdigit}");
