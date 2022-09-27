/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

//Решение 1
Console.WriteLine("Введите день недели");
int nameDay = Convert.ToInt32(Console.ReadLine());
if (nameDay % 6 == 0||nameDay % 7 == 0) 
{
    Console.WriteLine("Да");
}
else Console.WriteLine("Нет");


/*Решение 2
Console.WriteLine("Введите день недели");

String[] array = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };

String nameDay = Console.ReadLine();

for (int i = 0; i < array.Length; i++)
{
    if (nameDay.ToLower() == array[i]) 
    {
        if (i < 5)
        {
            Console.WriteLine($"{nameDay} - этот день не выходной");
            break;
        }
        else Console.WriteLine($"{nameDay} - этот день выходной");
        break;
    }
}*/


