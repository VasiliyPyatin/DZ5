// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

using System;
using static System.Console;

Clear();

WriteLine("Введите длину массива: ");
int length = int.Parse(ReadLine());
WriteLine("Введите минимальный диапазон: ");
int minValue = int.Parse(ReadLine());
WriteLine("Введите максимальный диапазон: ");
int maxValue = int.Parse(ReadLine());

double[] array = new double [length];

for (int i=0; i < array.Length; i++)
{
    array[i] = new Random().Next(minValue, maxValue+1);
}
WriteLine($"[{String.Join(", ",array)}]");

double min = array[0];
for (int i=1; i < array.Length; i++)
{
    if (min>array[i]) min = array[i];
}

double max = array[0];
for (int i=1; i < array.Length; i++)
{
    if (max<array[i]) max = array[i];
}

double difference = max - min;

WriteLine($"Разница между {max} и {min} равна {difference}");


