// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


int InputInt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

void ShowNumbers(int start, int finish)
{
    if (start > finish)
    {
        return;
    }
    ShowNumbers(start + 1 , finish);
    if (start % 2 == 0)
    {
        System.Console.Write($"{start}; ");
    }
}

int number1 = InputInt("Введите число M");
int number2 = InputInt("Введите число N");

ShowNumbers(number1, number2);