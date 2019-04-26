using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuing = true;
            string input;

            Console.WriteLine("Welcome to the Pig Latin Translator.");

            while(continuing)
            {
                Console.WriteLine("Enter a word to be translated: ");

                foreach(string word in Console.ReadLine().Split(' '))
                {
                    Console.Write(TranslateToPigLatin(word) + " ");
                }

                Console.WriteLine();

                Console.WriteLine("Do you want to enter another word? (Y/N)");

                if (Console.ReadLine().ToUpper() == "N")
                {
                    continuing = false;
                }
                
            }
        }
        
        public static string TranslateToPigLatin(string input)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};
            char first = input[0];
            // i thought this would look cleaner with just the return line instead of a bunch of if/else conditionals to
            // respect the case but now I'm second guessing...
            return vowels.Contains(first) ? input + "way" : (char.IsUpper(first) ? (char.ToUpper(input[1]) + input.Substring(2) ) : input.Substring(1)) + first.ToString().ToLower() + "ay";
        }
    }
}
