﻿// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число");

int TakeNum(int num)
{
    Console.WriteLine(num);
    return num / 10 % 10;
}

int result = TakeNum(new Random().Next(100, 1000));
Console.WriteLine(result);

 



