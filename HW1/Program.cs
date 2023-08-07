//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите число a ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
int min = number2;

if (number2 < number1)
{
    max = number1;
    min = number2;
    Console.Write("Большее число a = " + max + "," + " меньшее число b = " + min);
}
else 
{
    max = number2;
    min = number1;
    Console.Write("Большее число b = " + max + "," + " меньшее число a = " + min);
}