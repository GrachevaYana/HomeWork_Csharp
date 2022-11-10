Console.WriteLine("Привет, дорогой друг!");
Console.WriteLine("Напиcали программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.");
Console.WriteLine("Примеры: 14 -> нет, 46 -> нет, 161 -> да. Давай проверим?");
string[] array = { "да", "нет" };
int Multiple(int num) //объявление функции
{
    int result = 0;
    int a1 = num % 23;//
    int a2 = num % 7;//
    if (a1 == 0 && a2 == 0) result = 0;
    else result = 1;
    return result;
}
Console.WriteLine("Введи любое целое число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine(array[Multiple(num)]);
