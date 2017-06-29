using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Jerome";
            //int lengthOfName = firstName.Length;
            //Console.WriteLine(firstName);
            //Console.WriteLine(lengthOfName);
            //string myFaveQuote = "\"It'a yam sham\" - Buffy Summers";
            //Console.WriteLine(myFaveQuote);

            //string escapeString = "I want a tab after this line \t I want a new line without WriteLine \nHi";
            //string escapeString2 = "I want to show a backslash here \\ Hey what's that noise? \a";
            //Console.WriteLine(escapeString);
            //Console.WriteLine(escapeString2);

            //Console.WriteLine("User one, please type something");
            //string userOneInput = Console.ReadLine();
            //Console.WriteLine("User two, please type something");
            //string userTwoInput = Console.ReadLine();

            //if (userOneInput == userTwoInput)
            //{
            //    Console.WriteLine("User 2 is a copy Cat!");
            //}
            //else
            //{
            //    Console.WriteLine("Way to be original");

            //string startOfSentence = "My best friend's name is ";
            //string endOfSentence = "Carlos.";

            //Console.WriteLine(startOfSentence + endOfSentence);
            ////another example
            //Console.WriteLine("My friend " + endOfSentence + " has a cute kid.");
            //Console.WriteLine("My friend {0} has a cute kid.", endOfSentence);

            //practice
            //Console.WriteLine("This is a tab \t \n This is a backspace\\.\n And this is a bell sound\a.");

            //Length Practice
            //Create variable
            //Console.WriteLine("Please type your first name.");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Please type your last name.");
            //string lastName = Console.ReadLine();
            //int lengthOfName = firstName.Length;
            //int lengthOfName2 = lastName.Length;
            //Console.WriteLine(lengthOfName);
            //Console.WriteLine(lengthOfName2);
            ////calculation for lengt longer,samsis.etc...
            //if (lengthOfName > lengthOfName2)
            //{
            //    Console.WriteLine("First name is longer.");
            //}
            //else if (lengthOfName2 == lengthOfName)
            //{
            //    Console.WriteLine("Samesis");
            //}
            //else
            //{
            //    Console.WriteLine("Last name is longer.");

            //create variabel for first name
            //create variable for second name
            //Print names are same or different

            string personOne = Console.ReadLine();
            string otherPerson = Console.ReadLine();
            if (personOne == otherPerson)
            {
                Console.WriteLine("These names are the same!");
            }
            else
            {
                Console.WriteLine("These names are different");
            }
            }

            }
        }
    

