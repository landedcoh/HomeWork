//  Напишите программу, которая принимает на вход цифру, 
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели ");
int number = Convert.ToInt32(Console.ReadLine());

if (0 < number && 8 > number)
{
    if (number > 5)
    Console.WriteLine("Да это выходной");
    else {
        Console.WriteLine("Нет, это рабочий день");
    }
}
else {
    Console.WriteLine("Это не день недели");
}