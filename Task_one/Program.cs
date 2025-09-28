using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите температуру в °C: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = celsius * 9 / 5 + 32;

        Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
    }
}