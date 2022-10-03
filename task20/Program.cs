/*Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 2D пространстве */



double LenghtFromCoordinates()
{
    Console.WriteLine("Введите значение точки 1 координаты X");
    int tochkaX1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение точки 1 координаты Y");
    int tochkaY1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите значение точки 2 координаты X");
    int tochkaX2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение точки 2 координаты Y");
    int tochkaY2 = Convert.ToInt32(Console.ReadLine());
   
    double result = Math.Sqrt(Math.Pow(tochkaX1 - tochkaX2, 2) + Math.Pow(tochkaY1 - tochkaY2, 2));
    return result;
} 

double result = LenghtFromCoordinates();
Console.WriteLine(result);



