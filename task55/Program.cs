/* Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя. */

int[,] GenerateArray(int height, int weight, int deviation)
{
    int[,] generatedArray = new int[height, weight];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            generatedArray[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return generatedArray;
}

bool[,] GenerateBoolArray(int height, int weight)
{
    bool[,] generatedArray = new bool[height, weight];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            generatedArray[i, j] = (new Random().Next(0, 2) != 0);
        }
    }
    return generatedArray;
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void showArray<T>(T[,] inputArray)
{
    printColorData($" \t");
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        printColorData($"{i}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        printColorData($"{i}\t");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i, j].ToString()}\t");
        }
        Console.WriteLine();
    }
}

int[,] turnMatrix(int[,] inputArray)
{
    if (inputArray.GetLength(0) == inputArray.GetLength(1))
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = i + 1; j < inputArray.GetLength(1); j++)
            {
                int buffer = inputArray[j, i];
                inputArray[j, i] = inputArray[i, j];
                inputArray[i, j] = buffer;
            }
        }
    }
    else Console.WriteLine("Матрицу невозможно перевернуть");
    return inputArray;
}


int[,] generatedArray = GenerateArray(5, 5, 100);
showArray(generatedArray);
bool[,] generatedBoolArray = GenerateBoolArray(10, 5);
showArray(generatedBoolArray);
int[,] swoppedArray = turnMatrix(generatedArray);
showArray(swoppedArray);

