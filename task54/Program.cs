/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int[,] GenerateArray(int height, int weight)
{
    int[,] generatedArray = new int[height, weight];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            generatedArray[i, j] = new Random().Next(0, 10);
        }
    }
    return generatedArray;
}

void PrintColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void ShowArray(int[,] inputArray)
{
    PrintColorData($" \t");
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        PrintColorData($"{i}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        PrintColorData($"{i}\t");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] GetDecreasedArray(int[,] incomingArray)
{
    for (int i = 0; i < incomingArray.GetLength(0); i++)
    {
        for (int j = 0; j < incomingArray.GetLength(1); j++)
        {
            for (int k = 0; k < incomingArray.GetLength(1) - 1; k++)
            {
                if (incomingArray[i, k] < incomingArray[i, k + 1])
                {
                    int temp = incomingArray[i, k + 1];
                    incomingArray[i, k + 1] = incomingArray[i, k];
                    incomingArray[i, k] = temp;
                }
            }
        }
    }
    return incomingArray;
}

Console.WriteLine($"Двумерный массив случайных чисел:");
int[,] generatedArray = GenerateArray(3, 4);
ShowArray(generatedArray);
Console.WriteLine($"Измененный массив с элементами строк, упорядоченными по убыванию:");
int[,] decreasedArray = GetDecreasedArray(generatedArray);
ShowArray(decreasedArray);

