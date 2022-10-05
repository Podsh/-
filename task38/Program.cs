/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double[] getRandomArray(int length, int startPoint, int endPoint)
{
    double[] resultArray = new double[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().NextDouble();
    }

    return resultArray;
}

void printArray(double[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

double diffMaxMinElementsOfArray(double[] incomingArray)
{
    double result = 0;
    double max = incomingArray[0];
    double min = incomingArray[0];
    for (int i = 1; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] > max)
        {
            max = incomingArray[i];
        }
        if (incomingArray[i] < min)
        {
            min = incomingArray[i];
        }
    }
    result = max - min;
    return result;
}

Console.WriteLine ("Задайте длину массива, введите целое число:");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Массив случайных вещественных чисел:");
double[] currentArray = getRandomArray(length, -99, 99);
printArray(currentArray);
double diff = diffMaxMinElementsOfArray(currentArray);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива составляет {diff}");