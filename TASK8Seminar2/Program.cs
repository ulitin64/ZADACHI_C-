/*
Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления. 
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

Console.WriteLine("Введите числа: ");

int Number1 = Convert.ToInt32(Console.ReadLine());
int Number2 = Convert.ToInt32(Console.ReadLine());

if (Number1 % Number2 == 0)
{
    Console.WriteLine("Кратное");
}
else
{
    Console.WriteLine($"Не кратное: остаток {Number1 % Number2}");
}
