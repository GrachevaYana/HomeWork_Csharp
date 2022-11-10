Console.WriteLine("Привет, дорогой друг!");
Console.WriteLine("Напиcали программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
Console.WriteLine("Примеры: A (3,6,8); B(2, 1, -7), -> 15.84; A(7, -5, 0); B(1, -1, 9)-> 11.53. Давай проверим?");
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int x1 = ReadInt("Значение координаты Х точки A: ");
int y1 = ReadInt("Значение координаты Y точки A: ");
int z1 = ReadInt("Значение координаты Z точки A: ");
int x2 = ReadInt("Значение координаты Х точки B: ");
int y2 = ReadInt("Значение координаты Y точки B: ");
int z2 = ReadInt("Значение координаты Z точки B: ");
int x3 = x2 - x1;
int y3 = y2 - y1;
int z3 = z1 - z2;
double length = Math.Sqrt(x3 * x3 + y3 * y3 + z3 * z3);
Console.Write($"Кратчайшее расстояние между точками равно {length}");



