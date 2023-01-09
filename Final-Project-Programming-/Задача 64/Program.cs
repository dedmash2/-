/*
    Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
*/

Console.WriteLine("Введите число N: ");
int num = int.Parse(Console.ReadLine() ?? "");

void Natural(int num)
{
    Console.Write(num + " ");
    num--;

    if (num >= 1)
    {
        Natural(num);
    }
}

Natural(num);
