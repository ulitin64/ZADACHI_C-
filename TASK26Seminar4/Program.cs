﻿/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 
*/

Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int howMuchIsTheDigits(int number)
{
    int Counter = 0;
    while (number!= 0)
    {
        number = number / 10;
        Counter++;
    }
    return Counter;
}

Console.WriteLine($"Количетсво цифр в числе {number} = {howMuchIsTheDigits(number)}");
