﻿/* 
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите число One: ");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число Two: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число Tree: ");
int numberTree = Convert.ToInt32(Console.ReadLine());

int Max= numberOne > numberTwo && numberOne > numberTwo
? numberOne: numberTwo > numberOne && numberTwo > numberTree
? numberTwo: numberTree;

Console.WriteLine(Max);

