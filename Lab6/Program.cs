using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool TranslateAgain = true;
            while (TranslateAgain == true)
            {
                //application prompts user for a word
                //application translates the text to Pig Latin and displays it on the console.
                //application asks user if they want to translate another word.

                //if Index [0] is a vowel, add + "way" to end of Length
                //if Index [0] is a consonant, take consonants up until the first vowel in the word, move it to the end
                //of the length, then add "ay". 

                //use Indexof String and Sub String types
                int line;

                Console.WriteLine("Welcome to the Pig Latin Translator! Oink Oink!");
                Console.WriteLine("Please enter a line you would like to translate:");

                line = int.Parse(Console.ReadLine());


            }
            string Translate;
            Console.WriteLine("Would you like to translate another word? (Y/N)");
            Translate = Console.ReadLine();
            if (Translate == "N" || Translate == "No" || Translate == "no" || Translate == "n")
                //needs to work with string.TranslateLower/Upper.
            {
            TranslateAgain = false;
            Console.WriteLine("See ya! Don't eat bacon!");
            }
        }
    }
}
