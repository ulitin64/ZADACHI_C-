/*
Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом
первого.
а = 5, b = 25 -> true
а = 2, b = 10 -> false
а = 9, b = -3 -> false
а = -3, b = 9 -> true
*/

{
    Console.WriteLine("Введите число а: ");
    int userNumber1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Квадрат числа: ");
    int userNumber2 = Convert.ToInt32(Console.ReadLine());

    if (userNumber2 == userNumber1 * userNumber1)
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine("false");
    }

}