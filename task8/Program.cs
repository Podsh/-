Console.WriteLine("Введите число");
int numberN = Convert.ToInt32(Console.ReadLine());
int count = 1;

Console.Write($"Все четные числа от 1 до {numberN}: ");

while (count != numberN+1)
{
if (count % 2 == 0) 
{
    Console.Write($"{count} ");
}
count++;
}