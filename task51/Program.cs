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

int getSumOfDiagonals(int[,] matrix)
{
    int sum = 0;
    int bound = Math.Min(matrix.GetLength(0), matrix.GetLength(1));
    for (int i = 0; i < bound; i ++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

int[,] twoDArray = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

print2DArray(twoDArray);
Console.WriteLine();
int sum = getSumOfDiagonals(twoDArray);
Console.WriteLine($"Сумма чисел главной диагонали равна {sum}");

