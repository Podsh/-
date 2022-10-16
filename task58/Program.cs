/* Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 

2 * 3 + 4 * 3 = 6 + 12 = 18
2 * 4 + 4 * 3 = 8 + 12 = 20

3 * 3 + 2 * 3 = 9 + 6 = 15
3 * 4 + 2 * 3 = 12 + 6 = 18 */


int[,] GenerateArray(int height, int weight)
{
    int[,] generatedArray = new int[height, weight];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            generatedArray[i, j] = new Random().Next(1, 5);
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

int[,] MultiplyMatrixes(int[,] generatedArray1, int[,] generatedArray2)
{
    int[,] multiplyMatrixes = new int[generatedArray1.GetLength(0), generatedArray2.GetLength(1)];

    for (int i = 0; i < generatedArray1.GetLength(0); i++)
    {
        for (int j = 0; j < generatedArray2.GetLength(1); j++)
        {
            for (int k = 0; k < generatedArray2.GetLength(0); k++)
            {
                multiplyMatrixes[i, j] += generatedArray1[i, k] * generatedArray2[k, j];
            }
        }
    }
    return multiplyMatrixes;
}

Console.WriteLine($"Первый двумерный массив случайных чисел:");
int[,] generatedArray1 = GenerateArray(2, 2);
Print2DArray(generatedArray1);
Console.WriteLine($"Второй двумерный массив случайных чисел:");
int[,] generatedArray2 = GenerateArray(2, 2);
Print2DArray(generatedArray2);
Console.WriteLine($"Произведение двух массивов в новой матрице:");
int[,] multiplyedMatrixesArray = MultiplyMatrixes(generatedArray1, generatedArray2);
Print2DArray(multiplyedMatrixesArray);
