/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

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

void Print2DArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[] GetArrayOfStringsSum(int[,] generatedArray)
{
    int[] stringsArray = new int[generatedArray.GetLength(1)];
    int[] sumArray = new int[generatedArray.GetLength(0)];
    for (int i = 0; i < generatedArray.GetLength(0); i++)
    {
        for (int j = 0; j < generatedArray.GetLength(1); j++)
        {
            stringsArray[j] = generatedArray[i, j];
        }
        sumArray[i] = SumOfStringElements(stringsArray);

    }
    return sumArray;
}

int SumOfStringElements(int[] array)
{

    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}

void GetNumberOfStringWitMinSum(int[] array)
{
    int minSum = array[0];
    int indexMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i] < minSum)
        {
            minSum = array[i];
            indexMin = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов в двумерном массиве - номер {indexMin + 1}");
}

void PrintArray(int[] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i] + "\t");
    }
    Console.WriteLine();
}


Console.WriteLine($"Двумерный массив случайных чисел:");
int[,] generatedArray = GenerateArray(3, 4);
Print2DArray(generatedArray);
int[] stringsArray = GetArrayOfStringsSum(generatedArray);
Console.WriteLine($"Одномерный массив сумм элементов строк:");
PrintArray(stringsArray);
GetNumberOfStringWitMinSum(stringsArray);