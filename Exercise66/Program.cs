﻿/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
void Sum(int m, int n)
{
    if(m == n)
    {
        Console.WriteLine($"{m}");
    }
    else
    {
        int sum = 0;
        for(int i = m; i<=n; i++)
        {
            sum = sum+i;
        }
        Console.WriteLine($"{sum}");
    }
}
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
Sum(m, n);