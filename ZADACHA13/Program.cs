/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число: ");

int number = int.Parse(Console.ReadLine());
int k = (int)Math.Log10(number)-2;
Console.WriteLine(k < 0 ? "В данном числе нет третьей цифры " : (number % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString());
Console.ReadLine();
