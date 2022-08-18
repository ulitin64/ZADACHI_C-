/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumber = SumNumber(number);

int SumNumber(int number)
{

    int counter = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = number - number % 10;
        result = result + (number - advance);
        number = number / 10;
    }
    return result;
}


Console.WriteLine("Сумма всех цифр в числе: " + sumNumber);