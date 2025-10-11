using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите температуру в °C: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double celsius))
        {
            double fahrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
        }
        else
        {
            Console.WriteLine("Ошибка: введите корректное число!");
        }
    }
}