Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int ostatok = number % 10;
Console.WriteLine($"Последняя цифра числа: {ostatok}");

