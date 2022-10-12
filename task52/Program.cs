/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


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

double[] averageOfColumns(int[,] generatedArray)
{
    int[] columnArray = new int[generatedArray.GetLength(0)];
    double[] sumArray = new double[generatedArray.GetLength(1)];
    for (int j = 0; j < generatedArray.GetLength(1); j++)
    {
        for (int i = 0; i < generatedArray.GetLength(0); i++)
        {
            columnArray[i] = generatedArray[i, j];
        }
        sumArray[j] = averageOfSum(columnArray);

    }

    return sumArray;
}

double averageOfSum(int[] array)
{
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    double average = Math.Round(sum / array.Length, 2);
    return average;
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

void printArray(double[] arrayToPrint)
{
    Console.Write("\t");
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write(arrayToPrint[i] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine($"Массив случайных целых чисел:");
int[,] generatedArray = generate2DArray(3, 4, 1, 10);
print2DArray(generatedArray);
double[] averageArray = averageOfColumns(generatedArray);
Console.WriteLine($"Средние арифметические значения каждого столбца:");
printArray(averageArray);

