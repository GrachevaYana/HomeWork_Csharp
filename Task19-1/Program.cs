Console.WriteLine("Привет, дорогой друг!");
Console.WriteLine("Напиcали программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine("Примеры: 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6. Давай проверим?");
//#include<stdio.h>
int main()
{
    int i, N, t, k;

    scanf("%d", &N);
    for (k = 2; k <= N; k++)
    {
        i = 2;
        t = 0;
        while (i < k)
        {
            if (k % i == 0)
            {
                t++;
            }
            i++;
        }
        if (t == 0)
        {
            printf("%d\n", k);
        }
    }
}