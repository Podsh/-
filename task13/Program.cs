/*Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int getThirdDigitFromNumber(int number)
{
    int count = 1;
    int result = number;
    while (result / 10 != 0)
    {
        count++;
        result = result / 10;
    }
    int upCount = 10;

    for (int i = 0; i < count - 3; i++)
    {
        upCount = upCount * 10;
    }
    number = number % upCount;
    number = number / (upCount / 10);
    return number;
}
    if (number > 99) 
    {
        Console.WriteLine($"Третья цифра введенного числа - {getThirdDigitFromNumber(number)}");
    }
    else
    {
        Console.WriteLine ("В данном числе нет третьей цифры");
    }

// getThirdDigitFromNumber(number);