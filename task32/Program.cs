﻿/* Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

int[] getRandomArray(int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }

    return resultArray;
}

void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

int[] getReverseArray(int[] incomingArray)
{
    for (int i = 0; i < incomingArray.Length; i++)
    {
        incomingArray[i] = incomingArray[i] * (-1);
    }
    return incomingArray;

}

int[] currentArray = getRandomArray(12, -9, 9);
printArray(currentArray);
int[] currentArray2 = getReverseArray(currentArray);
printArray(currentArray2);
