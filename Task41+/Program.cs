//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2-> 2
//1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите массив чисел (положительных и отрицательных), разделяя их запятой: ");
string massive = Console.ReadLine();
int[] numbers = ParseStringToArray(massive);
PrintArray(numbers);
//функция, которая приводит значения введенные польователем, в массив чисел
int[] ParseStringToArray(string input)
{
    int countNumbers = GetCountNumbersInString(input);
    int[] numbers = new int[countNumbers];
    int indexNumber = 0;
    string substring = string.Empty;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] != ',')
        {
            substring += massive[i];
        }
        else
        {
            numbers[indexNumber] = Convert.ToInt32(substring);
            indexNumber++;
            substring = string.Empty;
        }
    }
    if (massive[massive.Length - 1] != ',')
        numbers[indexNumber] = Convert.ToInt32(substring);
    return numbers;
}

//функция подсчета длины массива
int GetCountNumbersInString(string massive)
{
    int count;
    if (massive[massive.Length - 1] == ',')
        count = 0;
    else
        count = 1;

    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] == ',')
            count++;
    }
    return count;
}

//функция вывода на печать массива, введенного пользователем
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

//функция подсчета кол-ва чисел больше 0
int CountPositive(int[] Numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (Numbers[i] > 0) count += 1;
    }
    return count;
}
Console.WriteLine();
Console.WriteLine("Введено чисел больше нуля: " + CountPositive(numbers));
