// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

using System;
using static System.Console;

Clear();

WriteLine("Введите длину массива: ");
int length = int.Parse(ReadLine());
int[] array = GetRandomArray(length);
WriteLine($"[{String.Join(", ",array)}] -> {CountEven(array)}");


int [] GetRandomArray (int size)
{
    int[] result = new int [size];
    for (int i=0; i<size; i++)
    {
        result[i]=new Random().Next(100, 1000);
    }
    return result;
}

int CountEven(int [] ar)
{
    int count = 0;
    for (int i = 0; i<ar.Length; i++)
    {
        if(ar[i]%2==0) count+=1;
    }
    return count;
}