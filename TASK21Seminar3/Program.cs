/*
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве. 
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

Console.WriteLine("Введите координаты точки А: ");
double dotAx = Convert.ToDouble(Console.ReadLine());
double dotAy = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
double dotBx = Convert.ToDouble(Console.ReadLine());
double dotBy = Convert.ToDouble(Console.ReadLine());

double dotC = Math.Sqrt(Math.Pow((dotAx) - (dotBx), 2) + Math.Pow((dotAy) - (dotBy), 2));
Console.WriteLine(dotC);
