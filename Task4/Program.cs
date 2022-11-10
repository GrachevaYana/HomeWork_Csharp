Console.WriteLine("Привет, дорогой друг!");
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Давай помогу узнать какое из трех чисел больше.");
Console.WriteLine("Для этого введи поочередно три числа.");
Console.WriteLine("Введи первое число: ");
int a1 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введи второе число: ");
int a2 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введи третье число: ");
int a3 = Convert.ToInt32(Console.ReadLine()!);
int maxnumber = a1;
if (a1 >= maxnumber) { maxnumber = a1; }
if (a2 >= maxnumber) { maxnumber = a2; }
if (a3 >= maxnumber) { maxnumber = a3; }
Console.WriteLine("Максимальное число равно " + maxnumber);
