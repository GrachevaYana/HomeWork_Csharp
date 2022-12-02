//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29


// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

// вывод результата расчета функции Аккермана
void PrintAkkerman(int m, int n)
{
    Console.Write(Akkerman(m, n));
}

Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

PrintAkkerman(m, n);

