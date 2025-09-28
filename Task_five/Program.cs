using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Количество слов: " + words.Length);

        int sentenceCount = 0;
        foreach (char c in text)
        {
            if (c == '.' || c == '!' || c == '?')
                sentenceCount++;
        }
        Console.WriteLine("Количество предложений: " + sentenceCount);

        int maxCount = 0;
        string frequentWord = "";
        foreach (string w in words)
        {
            int count = 0;
            foreach (string w2 in words)
            {
                if (w.ToLower() == w2.ToLower())
                    count++;
            }
            if (count > maxCount)
            {
                maxCount = count;
                frequentWord = w.ToLower();
            }
        }
        Console.WriteLine("Самое частое слово: " + frequentWord + " (" + maxCount + " раз)");

        int totalLength = 0;
        foreach (string w in words)
        {
            totalLength += w.Length;
        }
        double avgLength = (double)totalLength / words.Length;
        Console.WriteLine("Средняя длина слов: " + avgLength);
    }
}