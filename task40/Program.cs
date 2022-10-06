/* Задача 40: Напишите программу, которая принимает на вход три числа 
и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше 
суммы двух других сторон. */

bool CheckFigureSide(double[] numbers, int sideIndex)
{
    double sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i != sideIndex)
        {
            sum += numbers[i];
        }
    }
    bool result = sum > numbers[sideIndex];
    return result;
}

bool CheckFigure(double[] figureSides)
{
    bool result = true;
    for (int i = 0; i < figureSides.Length; i++)
    {
        result = result && CheckFigureSide(figureSides, i);
    }
    return result;
}

double[] arr = new double[3]
{
    2, 2, 3
};

if (CheckFigure(arr))
{
    Console.WriteLine("Это треугольник!");
}
else
{
    Console.WriteLine("Это НЕ треугольник!");
}