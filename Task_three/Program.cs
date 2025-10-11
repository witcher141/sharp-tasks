using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int secret = random.Next(1, 11);

        Console.WriteLine("Я загадал число от 1 до 10. Попробуйте угадать!");

        while (true)
        {
            Console.Write("Ваш вариант: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int guess))
            {
                Console.WriteLine("Ошибка: введите целое число!");
                continue;
            }

            if (guess < 1 || guess > 10)
            {
                Console.WriteLine("Введите число от 1 до 10!");
                continue;
            }

            if (guess == secret)
            {
                Console.WriteLine("Поздравляю! Вы угадали число!");
                break;
            }
            else if (guess < secret)
            {
                Console.WriteLine("Моё число больше.");
            }
            else
            {
                Console.WriteLine("Моё число меньше.");
            }
        }
    }
}