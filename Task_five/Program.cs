using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        char[] punctuation = { '.', ',', '!', '?', ':', ';', '"', '(', ')', '[', ']', '{', '}' };

        string[] rawWords = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        List<string> words = new List<string>();
        foreach (string w in rawWords)
        {
            string clean = w.Trim(punctuation).ToLower();
            if (clean.Length > 0)
                words.Add(clean);
        }

        Console.WriteLine($"Количество слов: {words.Count}");

        int sentenceCount = 0;
        foreach (char c in text)
        {
            if (c == '.' || c == '!' || c == '?')
                sentenceCount++;
        }
        Console.WriteLine($"Количество предложений: {sentenceCount}");

        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        foreach (string w in words)
        {
            if (wordCount.ContainsKey(w))
                wordCount[w]++;
            else
                wordCount[w] = 1;
        }

        string mostFrequentWord = "";
        int maxCount = 0;
        foreach (var pair in wordCount)
        {
            if (pair.Value > maxCount)
            {
                maxCount = pair.Value;
                mostFrequentWord = pair.Key;
            }
        }
        Console.WriteLine($"Самое частое слово: {mostFrequentWord} ({maxCount} раз)");

        int totalLength = 0;
        foreach (string w in words)
        {
            totalLength += w.Length;
        }
        double avgLength = (double)totalLength / words.Count;
        Console.WriteLine($"Средняя длина слов: {avgLength:F2}");
    }
}
