// Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


int Number(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool Weekend(int wd)
{
    if (wd > 5)
    {
        return true;
    }
    return false;
}
bool Weekday(int number)
{
    if (number <= 7);
    {
        return true;
    }
    return false;
}

int wd = Number("Введите день недели");

if (Weekend(wd))
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Будни");
}