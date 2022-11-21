//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество двухзначных элементов массива.
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2]-> 0
//[10, 11, 12, 13, 14]-> 5
// НАДО ДОПИСАТЬ!!!

int[] massive = GetArray(5);
PrintArray(massive);
//int length = 5;

//создаем функцию которая создает массив случайных чисел из 5 чисел
int[] GetArray(int length)
{
    int[] array = new int[length];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    { 
    array[i] = rnd.Next();
    }
    return array;
}

//создаем функцию для подсчета кол-ва двузначных чисел
int CountNumber(int[] array)
{ 
int count = 0;
    foreach (int ITEM in array)
    { 
    if (ITEM >10&&ITEM <100)
            count++;
    }
return count;
}



