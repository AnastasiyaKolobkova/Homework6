// Домашняя работа 6.
// Задача 1.
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void NumbersGreaterThanZero()
{
    Console.Write("Input the number of numbers: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input the number under the number {i + 1} - ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"The number of numbers greater than zero: {count}");
}

NumbersGreaterThanZero();

// Задача 3.
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void IntersectionOfStraightLines(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        Console.WriteLine("Straight lines don't intersect");
    }
    else
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = Math.Round(k2 * x + b2, 2);
        Console.WriteLine($"Coordinates of the intersection of two straight lines: ({x}; {y})");
    }
}

Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
IntersectionOfStraightLines(b1,k1,b2,k2);