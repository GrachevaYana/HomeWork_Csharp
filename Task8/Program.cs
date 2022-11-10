//Задача 8: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4, 8 -> 2, 4, 6, 8

Console.WriteLine("N:");
int user_number = int.Parse(Console.ReadLine()!);
for (int i = 0; i < user_number; i++)
    if (i % 2 != 0)
    {
        Console.WriteLine(i + 1);
    }
