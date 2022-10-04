/* Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */


int getSumOfDigits(string userNumberString)
{
    int result = 0;
    int tmp = 0;
    int userNumber=0;
    userNumber = Convert.ToInt32(userNumberString);
    int userNumberLength = (userNumberString).Length;
    for (int i = 0; i < userNumberLength; i++)
    {
        tmp = userNumber % 10;
        result = result + tmp;
        userNumber = userNumber / 10;
    }
    return result;
}

Console.WriteLine("Введите число");
string userNumber = Console.ReadLine();
int sumOfDigits = getSumOfDigits(userNumber);
Console.WriteLine($"Сумма цифр числа {userNumber} равна {sumOfDigits}");