Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int square = numberB * numberB;
if (square == numberA)
{
    Console.WriteLine("Да, первое число является квадратом второго");
}
else 
{
    Console.WriteLine("Нет, первое число не является квадратом второго");
}