using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите пароль: ");
        string password = Console.ReadLine();

        bool isValid = true;

        if (password.Length < 8)
        {
            Console.WriteLine("Пароль должен быть не короче 8 символов.");
            isValid = false;
        }

        bool hasDigit = false;
        foreach (char c in password)
        {
            if (char.IsDigit(c))
            {
                hasDigit = true;
                break;
            }
        }
        if (!hasDigit)
        {
            Console.WriteLine("Пароль должен содержать хотя бы одну цифру.");
            isValid = false;
        }

        bool hasUpper = false;
        foreach (char c in password)
        {
            if (char.IsUpper(c))
            {
                hasUpper = true;
                break;
            }
        }
        if (!hasUpper)
        {
            Console.WriteLine("Пароль должен содержать хотя бы одну заглавную букву.");
            isValid = false;
        }

        string specialChars = "!@#$%^&*";
        bool hasSpecial = false;
        foreach (char c in password)
        {
            if (specialChars.Contains(c))
            {
                hasSpecial = true;
                break;
            }
        }
        if (!hasSpecial)
        {
            Console.WriteLine("Пароль должен содержать хотя бы один спецсимвол (!@#$%^&*).");
            isValid = false;
        }

        if (isValid)
        {
            Console.WriteLine("Пароль надежный!");
        }
    }
}