/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите число M");
int userNumberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int userNumberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Числа в промежутке от {userNumberM} до {userNumberN}:");
PrintRange(userNumberM, userNumberN);
int sumOfRange = GetSumOfRange(userNumberM, userNumberN, userNumberM);
Console.WriteLine();
Console.WriteLine($"Сумма натуральных чисел в промежутке от {userNumberM} до {userNumberN} равна {sumOfRange}");

void PrintRange(int numberM, int numberN)
{
    if (numberM == numberN)
    {
        return;
    }
    PrintRange(numberM, numberN - 1);
    Console.Write($"{numberN} ");
}

int GetSumOfRange(int numberM, int numberN, int count)
{
    count++;
    numberM += count;
    if(count == numberN)
    {
        return numberM;
    }
    return GetSumOfRange(numberM, numberN, count);
}
