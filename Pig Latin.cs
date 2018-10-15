using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        // This method translates the inputed word to Pig Latin
        static void TranslateWord(string word)
        {
            // The inputed word is converted to lower case
            word = word.ToLower();
            string vowels = "AEIOUaeiou";
            string cons = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";

            // 'way'prints after inputed word if it begins with a vowel
            if (vowels.Contains(word.Substring(0, 1)))
            {
                word = word + "way";
                Console.WriteLine($"{word}");
            }
            else
            {
                for (int x = 0; x < word.Length; x++)
                {
                    // consonants that appear after the first vowel in the inputed word move to the end of the word
                    // 'ay' prints after inputed word once consonants have moved
                    if (vowels.Contains(word[x]))
                    {
                        string wordstart = word.Substring(0, x);
                        string wordend = word.Substring(x, word.Length - x);
                        Console.WriteLine($"{wordend}{wordstart}ay");

                        break;
                    }
                }
            }
        }

        // The below method calls the TranslateWord method (above)
        static void Main(string[] args)
        {
            bool answerYes = true;
            while (answerYes == true)
            {
                // The user is prompted to enter a word
                Console.WriteLine("Enter a word");

                string word = Console.ReadLine();

                TranslateWord(word);

                // The application asks the user if they want to continue; program continues to run if they input 'y'
                Console.WriteLine("Would you like to translate another word?" + " y/n");
                string answer= Console.ReadLine();
                answerYes = answer == "y";
            }
        }
    } 
}
