/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

int[] FibonacciN(int numberN)
{
    int[] fArray = new int[numberN];
    fArray[0] = 0;
    fArray[1] = 1;
    for (int i = 2; i < numberN; i++)
    {
        fArray[i] = fArray[i - 1] + fArray[i - 2];
    }
    return fArray;
}

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
void printConsole (string message)
{
    Console.Write(message);
}

void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int number = getNumberFromUser("Введите N");
int[] Fibonacci = FibonacciN(number);
printArray(Fibonacci);