/*
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

*/
int Number = new Random().Next(100,999);

int Number1 = Number / 100 * 10;
int Number2 = Number % 10;

Console.WriteLine(Number);

Console.WriteLine(Number1 + Number2);