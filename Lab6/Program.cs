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

                //input
                string line;

                //add validation to even start translator
                //Do extended challenges


                BeginYorN();
                
            

                line = Console.ReadLine().ToLower();
                // only trimes from outside line.Trim(new char[] { '\'' }); //does this go here? removes apostrophe?
                //use string replace and replace ' with "" (nothing)

                //must allow punctuation? 
                //convert each word to a lower case
                //no special characters allowed. And no contractions. 
                //must translate a whole line, not just one word.


                if (line[0] == 'a' || line[0] == 'e' || line[0] == 'i' || line[0] == 'o' || line[0] == 'u') //checks if first index of string is a vowell

                {
                    //char[] specialChars = new[] { '!', '?', ':', '*', '#', '%', '~', '&' };
                    //find at end of index and move to end (punctuation)
                    //prints "way" at end of string(line)
                    Console.WriteLine(line + "way");
                    //line.Trim(new char[] { '\'' }); //or does this go here? removes apostrophe?
                    TranslateAgain = false;
                }

                else
                {
                    char[] chars = { 'a', 'e', 'i', 'o', 'u' };
                    //char[ specialChars = new[] { '!', '?', ':', '*', '#', '%', '~', '&' };
                    int firstInstance = line.IndexOfAny(chars);
                    Console.WriteLine(line.Substring(firstInstance) + line.Substring(0, firstInstance) + "ay");
                    //line.Trim (new char[] { '\''}); //and/or here? removes apostrope?
                    TranslateAgain = false;
                }


                string Translate;
                Console.WriteLine("Would you like to translate another word? (Y/N)");
                Translate = Console.ReadLine().ToLower();
                if (Translate == "N" || Translate == "No")

                {
                    TranslateAgain = false;
                    Console.WriteLine("See ya! Don't eat bacon!");
                }

                else
                {
                    TranslateAgain = true;
                }
            }
        }

        public static string BeginYorN()
        {
           Console.WriteLine("Welcome to the Pig Latin Translator! Oink Oink! Would you like to translate? (Y/N)");

           string start = (Console.ReadLine());

           while ((Console.ReadLine() != "y") || (Console.ReadLine() != "Y") || (Console.ReadLine() != "n") || (Console.ReadLine() != "N"))
           {
                Console.WriteLine("Please select Y or N");
           }
             return start;
        }
    }
}
