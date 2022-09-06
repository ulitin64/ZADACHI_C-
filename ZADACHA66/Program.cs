/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму чётных чисел натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 56
M = 4; N = 8. -> 18
*/

int m = InputNumbers("Введите значение М: ");
int n = InputNumbers("Введите значение N: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

PrintSum(m, n, temp - 1);

void PrintSum(int m, int n, int sum)
{
    sum = (sum + n / 2);
    if (n < m)
    {
        Console.Write($"Сумма четных чисел= {sum} ");
        return;
    }
    PrintSum(m, n - 1, sum);
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}