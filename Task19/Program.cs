﻿/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

Console.Write("Введите пятизначное число: ");
string N = Console.ReadLine();
if (int.Parse(N) < 1000 || int.Parse(N) > 99999)
{
    Console.WriteLine("Число не является пятизначным. Введите число снова");
}
else
{
    if (N[0] == N[4] && N[1] == N[3])
    {
        Console.WriteLine($" Число {N} является полиндромом");
    }
    else
    {
        Console.WriteLine(" Число НЕ является полиндромом");
    }
}
