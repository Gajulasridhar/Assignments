using System;
using System.Collections.Generic;

class WordCount
{
    static void Main(string[] args)
    {
        // Check if a sentence is provided as a command line argument
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide a sentence as a command line argument.");
            return;
        }

        string sentence = string.Join(" ", args);

        Dictionary<string, int> wordFrequencies = GetWordFrequencies(sentence);

        foreach (var kvp in wordFrequencies)
        {
            Console.WriteLine($"{kvp.Key} - {kvp.Value}");
        }
    }

    static Dictionary<string, int> GetWordFrequencies(string sentence)
    {
        string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordFrequencies = new Dictionary<string, int>();

        foreach (string word in words)
        {
            string lowerCaseWord = word.ToLower();

            if (wordFrequencies.ContainsKey(lowerCaseWord))
            {
                wordFrequencies[lowerCaseWord]++;
            }
            else
            {
                wordFrequencies[lowerCaseWord] = 1;
            }
        }

        return wordFrequencies;
    }
}
