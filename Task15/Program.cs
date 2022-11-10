Console.WriteLine("Привет, дорогой друг!");
Console.WriteLine("Напиcали программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.WriteLine("Примеры: 6 -> да, 7 -> да, 1 -> нет. Давай проверим?");
Console.WriteLine("Введи целочисленное число от 1 до 7: ");
int find = int.Parse(Console.ReadLine()!);//проверим является ли число 4 элементом массива и узнаем его позицию
int[] arrayweekend = { 1, 2, 3, 4, 5 };
int n = arrayweekend.Length; //кол-во значений в массиве рабочих дней
int indexweekend = 0;
while (indexweekend < n)
{
    if (arrayweekend[indexweekend] == find)
    {
        Console.WriteLine($"нет");//вывод позиции массива
    }
    indexweekend++;
}
int[] arrayworkday = { 6, 7 };
int m = arrayworkday.Length; //кол-во значений в массиве выходных дней
int indexworkday = 0;
while (indexworkday < m)
{
    if (arrayworkday[indexworkday] == find)
    {
        Console.WriteLine($"да");//вывод позиции массива
    }
    indexworkday++;
}

