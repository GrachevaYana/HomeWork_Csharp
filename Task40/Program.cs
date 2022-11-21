//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
using System;

int Read(string text) //Функция, которая принимает значения от пользователя, пишет текст в консоль, меняет тип данных введенных пользователем на int
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}
int numA = Read("А: ");
int numB = Read("B: ");
int numC = Read("C: ");

bool Treugolnik(int a, int b, int c)//функция определения треугольника
{
    bool result = true;
    if ((a + b - c > 0) && (a + c - b > 0) && (b + c - a > 0))
    result = true;
    else result = false;
    return result;
}
Console.WriteLine("Это треугольник: "+ Treugolnik(numC, numA, numB));