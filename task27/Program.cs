/* Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int getSumOfDigits(int userNumber)
{
    int result = 0;
    int buff = 0;
    int userNumberLength = Convert.ToString(userNumber).Length;
    for (int i = 0; i < userNumberLength; i++)
    {
        buff = userNumber - userNumber % 10;
        result = result + (userNumber - buff);
        userNumber = userNumber / 10;
    }
    return result;
}

Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());
int sumOfDigits = getSumOfDigits(userNumber);
Console.WriteLine($"Сумма цифр числа {userNumber} равна {sumOfDigits}");