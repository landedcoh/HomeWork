// Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число N ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = 1;
int i = 1 + number2;
while (i < number1 + 1) {
    Console.Write(i + ", ");
    i = i + 2;
}