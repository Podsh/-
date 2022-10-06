/* Задача 42: Напишите программу, которая будет преобразовывать 
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

int getNumberFromUser(string userInformation)
{
    int result;
    Console.Write($"{userInformation}: ");
    while (!int.TryParse(Console.ReadLine(), out result) || result <= 0)
    {
        Console.Write($"Ошибка ввода! Ожидается число больше нуляю {userInformation}: ");
    }
    return result;
}

int getLengthBoolArray(int number)
{ 
   int count = 0;
   while (number != 0)
    {
        number /= 2;
        count++;
    }
    return count;
}

bool[] getBoolArray(int number)
{
    int length = getLengthBoolArray(number);
    bool[] boolArray = new bool[length];
    for (int i = 0; i < length; i++)
    {
        boolArray[length - i - 1] = number % 2 != 0;
        number /= 2;
    } 
    return boolArray;
}

void printBoolArray (bool[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]?"1":"0");
    }
    Console.WriteLine();

}

int number = getNumberFromUser("Введите число");
bool[] boolArray = getBoolArray(number);
printBoolArray(boolArray); 

