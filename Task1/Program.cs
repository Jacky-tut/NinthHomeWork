/*  Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


void stringNumber(int number)
{
    if (number == 1)
    {
        Console.Write(number);
    }
    else
    {
        Console.Write($"{number}, ");
        stringNumber(--number);
    }
}

stringNumber(8);