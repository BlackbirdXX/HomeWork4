// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using System;
using static System.Console;
Clear();

Write("Программа, которая задаёт массив из 8 элементов и выводит их на экран.");

int[] array = CreateRandomArray(8, 0, 10);

WriteLine($"\n[{String.Join(",", array)}]");

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue);
    }
    return newArray;
}

