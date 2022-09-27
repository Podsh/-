/*Напишите программу, 
которая выводит случайное трёхзначное число 
и удаляет вторую цифру этого числа. 
456 -> 46 782 -> 72 918 -> 98*/

int number = new Random().Next(100, 1000);

int getDeleteTwoDigitFromNumber(int number)
{
    int maxDigit = 0;
    while (number > 0)
    {
        int currentDigit = number % 10;
        if(maxDigit < currentDigit)
        {
            maxDigit = currentDigit;
        }
        number = number / 10;
        Console.WriteLine(number);
    }
    return maxDigit;
}
{
    for (int i = 0; i < 3; i++);
    {
        
    }
}

Console.WriteLine(number);
Console.WriteLine(getDeleteTwoDigitFromNumber(number));