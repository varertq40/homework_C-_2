// Задача 15: Напишите программу, которая приниает
// на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine()!);

if (number >= 1 && number <= 7)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine($"{number}-го выходной");
    }

    else
    {
        Console.WriteLine($"{number}-го рабочий");
    }
} 
else 
{
    Console.WriteLine("Введенное число не обозначает день недели");
}
