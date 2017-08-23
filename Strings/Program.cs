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

            string firstName = "Lily";
            string lastName = "Krichels";
            string fullName = string.Concat(firstName, " ", lastName);

            Console.WriteLine("Your initials are " + firstName[0] + lastName[0]);
            Console.WriteLine(firstName[firstName.Length -1]); //this will return the last letter, the index of the last letter and the last letter are different 
            Console.WriteLine(firstName.Equals(lastName));
            Console.WriteLine(fullName == lastName);
            Console.WriteLine();
            Console.WriteLine("My favorite book is \"A Guide to the Good Life\"");

            string example = "oneTwoThree";
            //substring takes a start, index 0 and a length, 6 indxes long
            string sub = example.Substring(3, 8);
            Console.WriteLine(sub);

            string index = "Mackelmore";
            string result = index.Remove(3);
            Console.WriteLine( result);
            Console.WriteLine(fullName.IndexOf("l"));

            string yell = "      \n\n\n    LILY";
            string newYell = yell.Trim();
            Console.WriteLine(yell);
            Console.WriteLine(newYell);

           
        }
    }
}
