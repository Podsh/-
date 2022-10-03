/* Задача 19: Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

string getNumberFromUser()
{
    int result = 0;
    String userLine = "";
    Console.WriteLine("Введите пятизначное число");

    while (userLine.Length != 5 || result==0)
    {
        userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (userLine.Length != 5 || result == 0 && userLine != "0")
        {
            Console.WriteLine($"Введите пятизначное число, вы ввели {userLine}");
        }
    }
    return userLine;
}

void checkPalindrome(string userNumber)
{
if (userNumber[0] == userNumber[4] && userNumber[1] == userNumber[3])
{
    Console.WriteLine($"Число {userNumber} является палиндромом");
}
else Console.WriteLine($"Число {userNumber} НЕ является палиндромом");
}

string userNumber = getNumberFromUser();
checkPalindrome(userNumber);
