/*
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

Console.WriteLine("Введите число N: ");
int num = int.Parse(Console.ReadLine());

int factorial(int number)
{
    int fact = 1;
    for (int i = 1; i <= num; i++)
    {
        fact *= i;
    }
    return fact;
}
Console.WriteLine($"Факториал {factorial(num)}");