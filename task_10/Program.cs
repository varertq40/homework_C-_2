// Задача 10: Напишите программу, которая принимает
// на вход трехзначное число и на выходе поазывает
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

Console.Write("Введитие трехзначное число ");
int number = int.Parse(Console.ReadLine()!);

if (number <= 1)
{
    Console.WriteLine("Нужно ввести трехзначное число");
}
else
{
    number = (number / 10) % 10;
    Console.WriteLine($"Вторая цифра {number}");
}