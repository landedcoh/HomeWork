//  Напишите программу,
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число a ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if (number2 > max)
{
    max = number2;
    if (number3 > max)
    {
        max = number3;
        Console.Write(max);
    }
    else 
    {
        max = number2;
        Console.Write(max);
    }
}
else if (number3 > max)
{
    max = number3;
    Console.Write(max);
}
else 
{
    max = number1;
     Console.Write(max);
}    