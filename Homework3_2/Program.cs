using System;
using System.Collections;
using System.Collections.Generic;

namespace Homework3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text;
            Dictionary<char, int> letterCount = new Dictionary<char, int>();
            List<char> nonLetters = new List<char>
            {
                '.', '!', ',', '?', ':', ';', '#', '@', '$', '&', '(',')', '-',
                '+', '=', '\"','\'', ' ', '\n', '1', '2', '3', '4', '5', '6',
                '7', '8','9', '0'
            };
            Console.WriteLine("Enter your text");
            text = Console.ReadLine();
            text = text.ToLower();
            for (int i = 0; i < text.Length; i++)
            {
                if (!letterCount.ContainsKey(text[i]))
                {
                    if (!nonLetters.Contains(text[i]))
                    {
                        letterCount.Add(text[i], 1);
                    }
                }
                else
                {
                    letterCount[text[i]] += 1;
                }
            }

            foreach (KeyValuePair<char, int> kvp in letterCount)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            Console.ReadKey();
        }
    }
    
}