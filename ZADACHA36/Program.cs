﻿/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях(по индексу считаем).
Например:
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Write("Введи количество элементов массива: ");
int numberElements = Convert.ToInt32(Console.ReadLine());

int RandomNumbers(int numberElements, int min, int max)
{
    int[] randomNumbers = new int[numberElements];
    int sumElements = 0;
    Console.WriteLine("Массив состоит из: ");

    for (int i = 0; i < randomNumbers.Length; i++)
    {
        randomNumbers[i] = new Random().Next(min, max);

        Console.WriteLine(randomNumbers[i] + " ");

        if (i % 2 != 0)
        {
            sumElements = sumElements + randomNumbers[i];
        }
    }
    return sumElements;
}

int randomNumbers = RandomNumbers(numberElements, 1, 100);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {randomNumbers}");