/* Задача 65: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" */

Console.WriteLine("Введите число M");
int userNumberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int userNumberN = Convert.ToInt32(Console.ReadLine());
PrintRange(userNumberM, userNumberN);

void PrintRange(int M, int N)
{
    if (M == N)
    {
        Console.Write($"{N}, ");
        return;
    }
    PrintRange(M, N - 1);
    Console.Write($"{N}, ");
}
