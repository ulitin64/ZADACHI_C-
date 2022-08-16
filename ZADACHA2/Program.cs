/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите число One: ");
int usernumberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число Two: ");
int usernumberTwo = Convert.ToInt32(Console.ReadLine());

if (usernumberOne > usernumberTwo)
{
Console.WriteLine($"Max = {usernumberOne}. Min = {usernumberTwo}");
}
else
{
Console.WriteLine($"Max = {usernumberTwo}. Min = {usernumberOne}");
}