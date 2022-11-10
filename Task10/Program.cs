Console.WriteLine("Привет, дорогой друг!");
Console.WriteLine("Напиcали программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.WriteLine("Примеры: 456-> 5, 782-> 8, 918-> 1. Давай проверим?");
int Read(string text) //Функция, которая принимает значения от пользователя, пишет текст в консоль, меняет тип данных введенных пользователем на int
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());//можно заменить на int.Parse
}
int GetLastDigit(int num) //объявление функции
{
    int LastDigit = num % 100;//от 3х значного числа отсекаем первую цифру
    int FirstDigit = LastDigit / 10;//от двухзначного числа оставляем первую цифру = она же вторая для 3хзначного
    return FirstDigit;
}
int num = Read("Введи любое трехзначное число: "); //задаем значение 3-хзначного числа
int SecondDigit = GetLastDigit(num);//записываем результат выполнения функции
Console.WriteLine($"Вторая цифра числа {num} равна {SecondDigit}.");
