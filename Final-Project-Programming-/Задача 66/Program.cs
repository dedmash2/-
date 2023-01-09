/*
    Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
*/

Console.WriteLine("Введите число N(побольше): ");
int N = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите число M(поменьше): ");
int M = int.Parse(Console.ReadLine() ?? "");

int NaturalSum(int N, int M)
{
    if (N == M)
    {
        Console.WriteLine(M);
    }
    int sum = M + NaturalSum(N, M + 1);
    Console.WriteLine(sum);

    return sum;
}

NaturalSum(N, M);
