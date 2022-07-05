// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System;
using static System.Console;

Clear();

WriteLine("Введите длину массива: ");
int length = int.Parse(ReadLine());
WriteLine("Введите минимальный диапазон: ");
int min = int.Parse(ReadLine());
WriteLine("Введите максимальный диапазон: ");
int max = int.Parse(ReadLine());


int[] array = GetRandomArray(length, min, max);
WriteLine($"[{String.Join(", ",array)}] -> {GetSumNotEven(array)}");



int [] GetRandomArray (int size, int minValue, int maxValue)
{
    int[] result = new int [size];
    for (int i=0; i<size; i++)
    {
        result[i]=new Random().Next(minValue, maxValue+1);
    }
    return result;
}

int GetSumNotEven (int [] ar)
{
    int sum = 0;
    for (int i = 1; i<ar.Length; i+=2)
    {
        sum = sum + ar[i];
    }
    return sum;
}