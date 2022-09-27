int firstNumber = new Random().Next(1, 100);
int secondNumber = new Random().Next(1, 10);

void ReturnOstatok(int firstNumber, int secondNumber)
{
    if (firstNumber % secondNumber == 0)
    {
        Console.WriteLine("Кратное");
    }
    else Console.WriteLine($"Не кратно, остаток {firstNumber % secondNumber}");
}
Console.WriteLine(firstNumber);
Console.WriteLine(secondNumber);
ReturnOstatok(firstNumber, secondNumber);