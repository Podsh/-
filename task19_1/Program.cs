/* Задача 19: Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

int getNumberFromUser()
{
    int result = 0;
    string userLine = "";
    Console.WriteLine("Введите пятизначное число");

    while (userLine.Length != 5 || result == 0)
    {
        userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (userLine.Length != 5 || result == 0 && userLine != "0")
        {
            Console.WriteLine($"Введите пятизначное число, вы ввели {userLine}");
        }
    }
    return result;
}

void checkPalindrome(int userNumber)
{
    if ((userNumber % 100) == (userNumber / 1000))
    {
        Console.WriteLine($"Число {userNumber} является палиндромом");
    }
    else Console.WriteLine($"Число {userNumber} НЕ является палиндромом");
}

int userNumber = getNumberFromUser();
checkPalindrome(userNumber);
