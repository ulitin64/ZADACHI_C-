/*
По данному натуральному числу N найдите сумму чисел 1+1/1!+1/2!+1/3!+...+1/N! . 
Количество действий должно быть пропорционально N. 
Напишите программу, которая считывает значение N и выводит результат в виде действительного числа
*/

Console.WriteLine("Введите число N: ");
int nNumber = Convert.ToInt32(Console.ReadLine());
double f = 1;
double cNum = 1;

for (int i = 1; i <= nNumber; i++)
{
    f = f * i;
    cNum = cNum + (1 / f);
    Console.Write($"{Math.Round(cNum, 2)}" );
}
