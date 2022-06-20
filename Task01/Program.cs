// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using System;
using static System.Console;
Clear();

Write("Программа принимает на вход два числа (A и B) \nи возводит число A в натуральную степень B. ");
WriteLine("\nВведите число A:");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите число B:");
int b = Convert.ToInt32(ReadLine());

WriteLine(Calculation(a, b));

double Calculation(double x, double y)
{
    if (x == 0) WriteLine("0 нельзя возводить в степень!");
    double result = Math.Pow(x, y);
    return result;
}
