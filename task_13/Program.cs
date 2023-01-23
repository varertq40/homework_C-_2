// Задача 10: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что 
// третьей цифры нет. (Цифры считать справо на лево).
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.Write("Введите трехзначное число ");
int number = int.Parse(Console.ReadLine()!);

if (number < 0)
{
    number = number * -1;
        if (number < 100)
        {
            Console.WriteLine("Третьей цифры нет");
        }  
        else
        {
            number = number / 100 % 10;
            Console.WriteLine($"Третья цифра {number}");
        }
}
else
    {
        if (number < 100)
        {
            Console.WriteLine("Третьей цифры нет");
        }
        else
            {   
                number = number / 100 % 10;
                Console.WriteLine($"Третья цифра {number}");
            }
    }
    
