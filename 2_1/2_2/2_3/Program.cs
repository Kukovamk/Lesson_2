﻿// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа
// выводит остаток от деления.

Console.WriteLine("Введите число");
Console.WriteLine("Введите число");

void Div(int num1, int num2)
{
    if (num1 % num2 == 0)
        Console.WriteLine("Кратно");
    else
        Console.WriteLine("Не кратно" + num1 % num2);
} 
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

Div(a, b);