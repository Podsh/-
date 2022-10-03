/* Задача 21: Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */


double LenghtFromCoordinates3D()
{
    Console.WriteLine("Введите значение координаты X для точки A");
    int pointX1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение координаты Y для точки A");
    int pointY1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение координаты Z для точки A");
    int pointZ1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите значение координаты X для точки B");
    int pointX2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение координаты Y для точки B");
    int pointY2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение координаты Z для точки B");
    int pointZ2 = Convert.ToInt32(Console.ReadLine());
   
    double result = Math.Sqrt(Math.Pow(pointX1 - pointX2, 2) + Math.Pow(pointY1 - pointY2, 2) + Math.Pow(pointZ1 - pointZ2, 2));
    return result;
} 

double result = LenghtFromCoordinates3D();
Console.WriteLine(result);

