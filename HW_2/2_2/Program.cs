// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Number(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int ThirdDigit(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
bool NonNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
         return false;
    }
    return true;
}
int number = Number("Введите число >");
if (NonNumber(number))
{
    Console.WriteLine(ThirdDigit(number));
}


// Понимаю, что нужно делать, а как записать не понимаю, посмотрела в интернете.