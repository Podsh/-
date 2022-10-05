/* Задача 37(сложная необязательная): Найдите произведение пар чисел 
в одномерном массиве. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */


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
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int[] multiplyOfPairsOfElementsOfArray(int[] incomingArray)
{
    int result = 0;
    int[] resultArray = new int[(incomingArray.Length / 2) + incomingArray.Length % 2];
    for (int i = 0; i < (incomingArray.Length / 2) + incomingArray.Length % 2; i++)
    {
        if (i != incomingArray.Length - 1 - i)
        {
            result = incomingArray[i] * incomingArray[incomingArray.Length - 1 - i];
            resultArray[i] = result;
        }
        else resultArray[i] = incomingArray[i];
    }
    return resultArray;
}


Console.WriteLine("Массив случайных чисел:");
int[] currentArray = getRandomArray(4, 1, 10);
printArray(currentArray);
int[] multiply = multiplyOfPairsOfElementsOfArray(currentArray);
Console.WriteLine($"Новый массив, полученный перемножением пар чисел:");
printArray(multiply);