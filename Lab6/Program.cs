﻿using System;
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

                //add validation to even start translator
                //Do extended challenges


                Console.WriteLine("Welcome to the Pig Latin Translator! Oink Oink! Would you like to translate? (Y/N)");
                string reply = ValidateYorN();
                

                if ((reply == "y") || (reply == "Y") || (reply == "yes") || (reply == "Yes"))
                {
                    VowelMethod();
                    TranslateAgain = false;
                }

                else if ((reply == "n") || (reply == "N") || (reply == "No") || (reply == "no"))
                {
                    Console.WriteLine("Okay, time-waster! Maybe next time!");
                    TranslateAgain = false;
                }


                string Translate;
                Console.WriteLine("Would you like to translate another word? (Y/N)");
                Translate = Console.ReadLine();
                if (Translate == "N" || Translate == "No" || Translate == "n" || Translate == "no")

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

        public static string ValidateYorN()
        {

            string reply = Console.ReadLine();
            while ((reply != "y") && (reply != "Y") && (reply != "n") && (reply != "N"))
            {
                Console.WriteLine("Please select Y or N");
                reply = (Console.ReadLine());
            }
            return reply;
        }

        public static void VowelMethod()
        {

            {
                Console.WriteLine("Please enter a line you would like to translate:");
                string line;
                line = Console.ReadLine().ToLower();
                line.Replace("'", ""); //????
                                       // only trimes from outside line.Trim(new char[] { '\'' }); //does this go here? removes apostrophe?
                                       //use string replace and replace ' with "" (nothing)

                //must allow punctuation? 
                //convert each word to a lower case
                //no special characters allowed. And no contractions. 
                //must translate a whole line, not just one word.
                //char[] sy mbols = { '1', '2', ....}
                //if (string.IndexofAny(symbols) != -1 || ....)

                    if (line[0] == 'a' || line[0] == 'e' || line[0] == 'i' || line[0] == 'o' || line[0] == 'u') //checks if first index of string is a vowell

                    {
                        //char[] specialChars = new[] { '!', '?', ':', '*', '#', '%', '~', '&' };
                        //find at end of index and move to end (punctuation)
                        //prints "way" at end of string(line)
                        Console.WriteLine(line + "way");
                        //line.Trim(new char[] { '\'' }); //or does this go here? removes apostrophe?

                    }

                    else
                    {
                        char[] chars = { 'a', 'e', 'i', 'o', 'u' };

                        int firstInstance = line.IndexOfAny(chars);
                        Console.WriteLine(line.Substring(firstInstance) + line.Substring(0, firstInstance) + "ay");
                    }
                }
                  
            
        }
    }
}
