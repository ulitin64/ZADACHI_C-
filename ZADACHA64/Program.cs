/*
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N от большего к меньшему.
M = 1; N = 5. -> ""5, 4, 3, 2, 1""
M = 4; N = 8. -> ""8, 7, 6, 5, 4""
*/

int m = InputNumbers("Введите значение M: ");
int n = InputNumbers("Введите значение N: ");

PrintNumber(n, m);
Console.WriteLine();

void PrintNumber(int n, int m)
{
    if (m > n) return;
    PrintNumber(n, m + 1);
    Console.Write(m + " ");
}

int InputNumbers(string input)
{
    Console.WriteLine(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}