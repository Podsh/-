/* Задача 45: Напишите программу, которая будет создавать копию 
заданного массива с помощью поэлементного копирования. */


double[] copyArray(double[] incomingArray)
{
    double[] arr = new double[incomingArray.Length];
    for (int i = 0; i < incomingArray.Length; i++)
    {
        arr[i] = incomingArray[i];
    }
    return arr;
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

double[] arr = { 2, 4, 8.3, 10 };
double [] arrCopy = copyArray(arr);
printArray(arr);
printArray(arrCopy);
