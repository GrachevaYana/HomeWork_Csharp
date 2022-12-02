//Задача 66: Задайте значения M и N. Напишите программу,
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30

// Функция подсчета суммы чисел от m до n
int Sum(int m, int n)
{
    int sum = 0;
    if (m == n)
        return 0;
    else
    {
        m++;
        sum = m + Sum(m, n);
        return sum;
    }
}

// Функция вызывающая функцию подсчета суммы чисел от m до n
void PrintSum(int m, int n)
{
    Console.Write(Sum(m - 1, n));
}

Console.Write("Введите число m, определяющее нижнюю границу массива: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число n, определяющее верхнюю границу массива и больше, чем первое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Сумма натуральных чисел массива от m до n равна: "); 
PrintSum(m, n);