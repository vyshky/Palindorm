using System;

namespace Palindrom
{
    class Program
    {
        static void Main()
        {
            string word;
            word = Console.ReadLine();

            Console.WriteLine($"Слово {word} {(IsPalindrom(word)? "": "НЕ ")} ПАЛИНДРОМ");
        }
        static bool IsPalindrom(string word)
        {
            for (int i = 0; i <= word.Length - i - 1; i++)
            {
                if (word[i] != word[word.Length - i - 1]) return false;
            }
            return true;
        }
    }
}