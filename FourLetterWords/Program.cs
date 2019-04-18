using System;

namespace FourLetterWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "This sentence is fine";
            string b = "So is this one";
            string c = "Hello";
            int x;

            UserSolution us = new UserSolution();

            Console.WriteLine(a);
            x = us.four_letter_words(a);
            Console.WriteLine(x.ToString());

            Console.WriteLine(b);
            x = us.four_letter_words(b);
            Console.WriteLine(x.ToString());

            Console.WriteLine(c);
            x = us.four_letter_words(c);
            Console.WriteLine(x.ToString());

        }
    }
}

// Function takes a sentence and returns the number of four letter words it contains
// Test inputs:
// "This sentence is fine" - Output: 2
// "So is this one" - Output: 1
// "Hello" - 0