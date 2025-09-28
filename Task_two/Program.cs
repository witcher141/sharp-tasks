using System;

class Program
{
    static void Main()
    {
        int sum = 0;

        while (true)
        {
            Console.Write("Введите число (0 для выхода): ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("Вы ввели 0. Программа завершена.");
                break;
            }

            sum += number;
            Console.WriteLine($"Текущая сумма: {sum}");
        }
    }
}