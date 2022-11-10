// See https://aka.ms/new-console-template for more information
var rnd = new Random(); //создаем переменную класса Random
rnd.Next();//
int num = rnd.Next(10, 100);
Console.WriteLine($"Провизвольное число на отрезке (10,100) равно {num}.");
int SecondDigit(int num) //функция расчета второй цифры
{
    int seconddigit = num % 10;//от 2х значного числа находим вторую цифру
    return seconddigit;
}
int FirstDigit(int num) //функция расчета первой цифры
{
    int firstdigit = num / 10;//от 2х значного числа находим первую цифру
    return firstdigit;
}
int max = 0;
if (FirstDigit(num) > max) max = FirstDigit(num);
if (SecondDigit(num) > max) max = SecondDigit(num);
Console.WriteLine($"Максимальная цифра из 2 цифр числа {num} равна {max}");
