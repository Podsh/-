int firstNumber = new Random().Next(1, 10);
int secondNumber = new Random().Next(1, 100);

string Square(int firstNumber, int secondNumber)
{
    string square = "";
if (firstNumber * firstNumber == secondNumber
|| secondNumber * secondNumber == firstNumber)
{
    square = "Да";
}
else square = "Нет";
return square;
}
Console.WriteLine(firstNumber);
Console.WriteLine(secondNumber);
string result = Square(firstNumber, secondNumber);
Console.WriteLine(result);