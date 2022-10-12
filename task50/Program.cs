/* Задача 50. Напишите программу, которая на вход принимает позицию элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
5 -> 9
2 -> 7
9 -> 4
индексы:
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4 */

int[,] generate2DArray(int height, int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i, j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return twoDArray;
}

int getNumberFromUser()
{
    Console.WriteLine("Введите целое положительное число для поиска элемента по номеру индекса");
    int numberFromUser = Convert.ToInt32(Console.ReadLine());
    return numberFromUser;
}

int[] getOneArrayFrowTwoArrays(int[,] generatedArray)
{
    int[] stringArray = new int[generatedArray.Length];
    for (int i = 0; i < generatedArray.GetLength(0); i++)
    {
        for (int j = 0; j < generatedArray.GetLength(1); j++)
        {
            stringArray[j + (generatedArray.GetLength(1) * i)] = generatedArray[i, j];
        }
    }
    return stringArray;
}

void findElementFromPosition(int[] generatedArray, int numberFromUser)
{
    if (numberFromUser >= generatedArray.Length || numberFromUser < 0)
    {
        Console.WriteLine($"Элемента с индексом {numberFromUser} не существует в массиве.");
    }
    else Console.WriteLine($"Элемент c индексом {numberFromUser} есть в массиве. Он содержит в себе следующее значение {generatedArray[numberFromUser]}");
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray(int[,] arrayToPrint)
{
    Console.Write("\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void printArray(int[] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write(arrayToPrint[i] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine($"Двумерный массив случайных целых чисел:");
int[,] generatedArray = generate2DArray(3, 4, 1, 10);
print2DArray(generatedArray);
Console.WriteLine($"Двумерный массив, выстроенный в одномерный:");
int[] arrayFromTwo = getOneArrayFrowTwoArrays(generatedArray);
printArray(arrayFromTwo);
int userNumber = getNumberFromUser();
findElementFromPosition(arrayFromTwo, userNumber);






