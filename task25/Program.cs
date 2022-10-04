/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int getNumbersFromUser(string label)
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(label);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if(result == 0 && userLine != "0")
        {
            Console.WriteLine($"Введите целое число, вы ввели {userLine}");
        }
    }
    return result;
}

int getDegree (int userNumberA, int userNumberB)
{
    int result = userNumberA;
    for (int i = 1; i < userNumberB; i++)
    {
        result = result * userNumberA;
    }
    return result;
}

int userNumberA = 0;
int userNumberB = 0;
Console.WriteLine("Введите число A");
userNumberA = getNumbersFromUser("A: ");
Console.WriteLine("Введите число B");
userNumberB = getNumbersFromUser("B: ");
int resultOfDegree = getDegree(userNumberA, userNumberB);
Console.WriteLine($"Результат возведения числа {userNumberA} в степень {userNumberB} равен {resultOfDegree}");






