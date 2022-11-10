//Напиши программу, которая будет выдавать название дня недели по заданному номеру
Console.WriteLine("Привет, дорогой друг!");
Console.WriteLine("Давай проверим какому дню недели соответствует введенное тобой число.");
string[] week_day = new string[8];
int var_user;
week_day[1] = "Понедельник";
week_day[2] = "Вторник";
week_day[3] = "Среда";
week_day[4] = "Четверг";
week_day[5] = "Пятница";
week_day[6] = "Суббота";
week_day[7] = "Воскресенье";
do
{
    Console.WriteLine("Введи целочисленное число от 1 до 7: ");
    var_user = int.Parse(Console.ReadLine()!);
    Console.WriteLine(week_day[var_user]);
}
while (var_user > 0 && var_user < 8);
