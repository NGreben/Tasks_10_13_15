/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int number;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out number);

if (number / 100 > 0)
{
    while (number > 999)
    {
        number = number / 10;
    }
    number = number % 10;
    Console.Write($"Третья цифра числа: {number}");
}
else
    Console.Write($"Третьей цифры нет");