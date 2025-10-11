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
        bool hasUpper = false;
        bool hasSpecial = false;
        string specialChars = "!@#$%^&*";

        foreach (char c in password)
        {
            if (char.IsDigit(c)) hasDigit = true;
            else if (char.IsUpper(c)) hasUpper = true;
            else if (specialChars.Contains(c)) hasSpecial = true;

            if (hasDigit && hasUpper && hasSpecial)
                break;
        }

        if (!hasDigit)
        {
            Console.WriteLine("Пароль должен содержать хотя бы одну цифру.");
            isValid = false;
        }
        if (!hasUpper)
        {
            Console.WriteLine("Пароль должен содержать хотя бы одну заглавную букву.");
            isValid = false;
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