Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB) 
{
    Console.WriteLine($"Максимальное значение - {numberA}, минимальное значение - {numberB}");
}
else if (numberA < numberB)
{
    Console.WriteLine($"Максимальное значение - {numberB}, минимальное значение - {numberA}");
}
else 
{
    Console.WriteLine($"Большего значения нет, т.к. значения равны между собой");
}
