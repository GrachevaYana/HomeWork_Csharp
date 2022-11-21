// See https://aka.ms/new-console-template for more information


//Функция, которая меняет тип данных введенных пользователем на int
int Read(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}
int ArrayLenght = Read("Введите длинну массива: ");

//создаем рандомный массив чисел
double[] random_array = new double[ArrayLenght];
Random random = new Random();
for (int i = 0; i < random_array.Length; i++)
{
    random_array[i] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
    Console.Write("{0,6:F2}", random_array[i]);
}

//функция определения максимального числа в массиве
double MaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    Console.WriteLine();
    return max;
}

//функция определения минимального числа в массиве
double MinNumber(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    Console.WriteLine();
    return min;
}
Console.WriteLine("{0,6:F2}", MaxNumber(random_array) - MinNumber(random_array));
