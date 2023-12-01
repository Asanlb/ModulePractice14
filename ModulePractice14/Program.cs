using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится В доме, Который построил Джек. А это веселая птица синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";

        Dictionary<string, int> wordFrequency = CountWordFrequency(text);

        Console.WriteLine("Слово\t\tКоличество");
        Console.WriteLine("-------------------------");

        foreach (var pair in wordFrequency)
        {
            Console.WriteLine($"{pair.Key}\t\t{pair.Value}");
        }
    }

    static Dictionary<string, int> CountWordFrequency(string text)
    {
        string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

        foreach (string word in words)
        {
            string cleanedWord = word.Trim(' ', ',', '.', '!', '?').ToLower();

            if (wordFrequency.ContainsKey(cleanedWord))
            {
                wordFrequency[cleanedWord]++;
            }
            else
            {
                wordFrequency[cleanedWord] = 1;
            }
        }

        return wordFrequency;
    }
}

