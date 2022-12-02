//Задача 64: Задайте значения N. Напишите программу, которая выведет
//все натуральные числа в промежутке от N до 1.
//N = 5. -> "5, 4, 3, 2, 1"
//N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число, котороое будет верхней границей массива натуральных чисел: ");
int uppernumber = int.Parse(Console.ReadLine()!);
int lowernumber = 1;
NaturalToLow(uppernumber, lowernumber);


void NaturalToLow(int uppernumber, int lowernumber)
{
    if (lowernumber > uppernumber)
    {
        return;
    }
    else
    {
        NaturalToLow(uppernumber, lowernumber + 1);
        Console.Write(lowernumber + ", ");
    }
}

