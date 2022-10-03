/* Нпишите программу, которая принимает на вход число (N) 
и выдает таблицу квадратов чисел от 1 до N
*/


int getNumberFromUser(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation}");
    while (!int.TryParse(Console.ReadLine(), out result) || result <= 1)
    {
        Console.WriteLine($"Ошибка ввода! Ожидается целое число больше единицы. {userInformation}");
    }
    return result;
    }

int number = getNumberFromUser("Введите целое число N > 1: ");

    int[] tableQuarterNumber(int number)
    {
        int[] result = new int[number];
        for(int i = 1; i <= number; i++)
        {
            result[i-1] = (int)(Math.Pow(i,2));
        }
        return result;
        }
int[] table = tableQuarterNumber(number);

/*
for(int i = 0; i < table.Lenght; i++)
{
    Console.Write(table[i]+"");
}*/

foreach (var value in table)
{
    Console.Write(value + " ");
}

