using System;

class Program
{
    static void Main(string[] args)
    {
        // Лямбда-вираз у делегаті Predicate
        Predicate<string> isNumber = input => double.TryParse(input, out _);

        // Введення рядка
        Console.Write("Введіть рядок: ");
        string input = Console.ReadLine();

        // Використання Predicate для перевірки
        if (isNumber(input))
        {
            Console.WriteLine($"\"{input}\" є числом.");
        }
        else
        {
            Console.WriteLine($"\"{input}\" не є числом.");
        }
    }
}
