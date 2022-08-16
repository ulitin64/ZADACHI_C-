/*
17.
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
в которой находится эта точка.
*/


int getQuoterFromCoordinate(int x, int y)
{
int result = 0;
if(x > 0 && y > 0)
{
    result = 1;
}
else if (x < 0 && y > 0)
{
result = 2;
}
else if (x < 0 && y < 0)
{
    result = 3;
}
else if (x > 0 && y < 0)
{
   result = 4; 
}
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"X и Y не должны быть равны 0 вы вели {x} {y}");
        Console.ResetColor();
    }
    return result;
}
int UserX = 0;
int UserY = 0;

Console.WriteLine("Введите Х: ");
UserX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y: ");
UserY = Convert.ToInt32(Console.ReadLine());
int quoter = getQuoterFromCoordinate(UserX,UserY);
Console.WriteLine($"Для координаты {UserX}:{UserY} находятся в {quoter} четверти");