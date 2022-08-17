/*
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

Console.WriteLine("Введите число N: ");
int numberN = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int getTheMultiply(int numberN)
{
    int result = 1;
    for (int i = 1; i <= numberN; i++)
    {
        result = result * i;
    }
    return result;
}

Console.WriteLine($"Произведение чисел от 1 до {numberN} = {getTheMultiply(numberN)}");