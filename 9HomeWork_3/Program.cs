﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Acr(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0) 
    return Acr(m - 1, 1);

    else 
    return Acr(m - 1, Acr(m, n - 1));
   
}
Console.Write($"A(m,n) = {Acr(3,2)}");