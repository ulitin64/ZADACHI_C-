/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> true
-3 -> fasle
7 -> fasle
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string result = number % 2 == 0 ? "yes" : "no";
Console.WriteLine(result);