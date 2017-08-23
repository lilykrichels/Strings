using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a word");
            //string phrase = Console.ReadLine();
            //Console.WriteLine("This word is " + phrase.Length + " characters long.");


            //Ask the user to guess the type of pet(Hint to the user it's the opposite of a dog)
            //Assign an answer variable to the answer of cat.
            //If they guess cat correctly, print "You guessed correctly!"
            //If they guess incorrectly, print "You guessed incorrectly..."
            //Use the ToLower() or ToUpper() methods to ensure if they enter cat or CAT or Cat, it will be correct.

            Console.WriteLine("Guess the type of animal I'm thinking of: ");
            string answer = "Cat";
            string userGuess = Console.ReadLine();
             if (userGuess.ToUpper() == answer.ToUpper())
            {
                Console.WriteLine("You guess correctly!");
            }
            else
            {
                Console.WriteLine("Please try again.");
            }


        }
    }
}
