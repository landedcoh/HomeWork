//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите число 1 ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 < number1)
{
    Console.Write("Большее число 1, а меньшее число 2");
}
else 
{
    Console.Write("Большее число 2, а меньшее число 1");
}