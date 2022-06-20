// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System;
using static System.Console;
Clear();

WriteLine("Программа, которая принимает на вход число и выдаёт сумму цифр в числе.");
WriteLine("Введите число:");
int n = Convert.ToInt32(ReadLine());

WriteLine($"-> {NumberSum(n)}");

int NumberSum(int x)
{
    int result = 0;
    for (int i = x; i > 0; i /= 10)
    {
        int intermediate = i % 10;
        result = result + intermediate;
    }
    return result;
}