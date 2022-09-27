/*Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int getSecondDigitFromNumber(int number)
{
    int secondDigit = number % 100;
    secondDigit = secondDigit / 10;
    return secondDigit;
}

int secondDigit = getSecondDigitFromNumber(number);
Console.WriteLine($"Для числа {number} вторая цифра {secondDigit}");