/* Задача 51: Задайте двумерный массив. 
Найдите Сумма элементов главной диагонали.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12 */

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

int[] getElementsOfDiagonals(int[,] matrix)
{
    int bound = Math.Min(matrix.GetLength(0), matrix.GetLength(1));
    int[] diagonal = new int[bound];
    for (int i = 0; i < bound; i++)
    {
        diagonal[i] = matrix[i, i];
    }
    return diagonal;
}

int getSumOfDiagonals(int[] diagonal)
{
    int sum = 0;
    for (int i = 0; i < diagonal.Length; i++)
    {
        sum += diagonal[i];
    }
    return sum;
}

void printArrayWithSum(int[] diagonal)
{
    Console.Write(diagonal[0]);
    for (int i = 1; i < diagonal.Length; i++)
    {
        Console.Write($" + {diagonal[i]}");
    }
    int sum = getSumOfDiagonals(diagonal);
    Console.Write($" = {sum}");
}

int[,] twoDArray = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

print2DArray(twoDArray);
Console.WriteLine();
int[] diagonal = getElementsOfDiagonals(twoDArray);
printArrayWithSum(diagonal);
