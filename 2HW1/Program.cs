﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
int a = 0;
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Введено не трехзначное число");
}
else
{
    a = number / 10 % 10;
    Console.WriteLine(a);
}