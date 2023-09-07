// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int Print(string text)
{
Console.WriteLine(text);
int number = Convert.ToInt32(Console.ReadLine());
return number;
}

int Rank(int A, int B)
{
    int rank = 1;
    for (int i = 0; i < B; i++)
    {
        rank = A * rank;
    }
    return rank;
}


bool Exponent(int B)
{
    if (B < 0)
    {
        Console.WriteLine("Степень не может быть отрицательной");
        return false;
    }
    return true;
}

int A = Print("Введите число A: ");
int B = Print("Введите число B: ");
if (Exponent(B)){
Console.WriteLine($"{A} в натуральную степень {B} = {Rank(A,B)}");
}