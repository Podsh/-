/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

//Console.WriteLine("Введите число");
//string userNumber = Console.ReadLine();
// char[] array = userNumber.ToCharArray();
//int result = array.Length;
// string length = Convert.ToString (userNumber);
// int Length = Text.Length;
//Console.WriteLine($"Количество знаков в числе - {result}");


Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());
userNumber = Math.Abs(userNumber);
int result = 1;
if (userNumber != 0)
{
    result = (int)Math.Log10(userNumber) + 1;
}
Console.WriteLine($"Количество знаков в числе - {result}");