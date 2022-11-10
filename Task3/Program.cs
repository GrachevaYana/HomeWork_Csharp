//Напиши программу, которая будет выдавать название дня недели по заданному номеру
Console.WriteLine("Привет, дорогой друг!");
Console.WriteLine("Давай проверим какому дню недели соответствует введенное тобой число.");
Console.WriteLine("Введи целочисленное число от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine()!);
if (a == 1) { Console.WriteLine("Это понедельник"); }
if (a == 2) { Console.WriteLine("Это вторник"); }
if (a == 3) { Console.WriteLine("Это среда"); }
if (a == 4) { Console.WriteLine("Это четверг"); }
if (a == 5) { Console.WriteLine("Это пятница"); }
if (a == 6) { Console.WriteLine("Это суббота"); }
if (a == 7) { Console.WriteLine("Это воскресенье"); }
else { Console.WriteLine("Введенное число не является целочисленным в пределах от 1 до 7. Попробуй еще раз."); }
