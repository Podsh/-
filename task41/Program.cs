/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

int[] GetNumbersFromUser(int number)
{
    int result = 0;
    int[] numbers = new int[number];
    Console.WriteLine($"Введите {number} целых чисел. Ввод осуществляйте последовательно, одно число за другим.");
    for (int i = 0; i < number; i++)
    {
        Console.WriteLine($"Введите число: ");
        int.TryParse(Console.ReadLine(), out result);
        numbers[i] = result;
    }
    return numbers;
}

int CountNumbersMoreThanZero(int[] numbers)
{
    int result = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            result++;
        }
    }
    return result;
}

int[] numbersFromUser = GetNumbersFromUser(5);
int count = CountNumbersMoreThanZero(numbersFromUser);
Console.WriteLine($"Среди введенных чисел {count} - положительные.");
