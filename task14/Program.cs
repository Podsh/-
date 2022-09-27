int number = new Random().Next(1, 1000);

string Kratno(int number)
{
    string kratno = "";
    if (number % 7 ==0 && number % 23 == 0) 
    {
        kratno = "Да, кратно";
    }
    else kratno = "Нет, не кратно";
    return kratno;
}
Console.WriteLine(number);
string result = Kratno(number);
Console.WriteLine(result);
