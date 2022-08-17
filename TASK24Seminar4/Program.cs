/*Напишите программу, которая принимает на вход число (N и выдаёт сумму чисел от 1 до N.
7 -> 28
4 -> 10
8 -> 36
*/

//задаём число N
//создаем метод возвращаемого типа, который будет выдавать сумму чисел от  до N
// задаём счетчик, который будет увеличиваться  каждый проход цикла
//добавляем переменную, которая будет содержать в себе сумму


Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int GetSumNums(int number)
{
    int sum = 0;
    int i = 1;
    while (i <= number)
    {
        sum += i;
        Console.Write($"{i} ");
        Console.WriteLine($"{sum} ");
        i++;
    }
    return sum;
}
Console.WriteLine($"Сумма чисел от 1 дол А = {GetSumNums(num)}");
