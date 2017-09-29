using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Problem 1
            //string firstName = "Ali";
            //string lastName = "Ware";

            //Console.WriteLine(firstName.Length);
            //Console.WriteLine(lastName.Length);

            //if (firstName.Length > lastName.Length)
            //{
            //    Console.WriteLine("First is longer.");
            //}
            //else if (firstName.Length == lastName.Length)
            //{
            //    Console.WriteLine("Sameses!");
            //}
            //else
            //{
            //    Console.WriteLine("Last must be longer!");
            //}



            ////Problem 2
            //Console.WriteLine("This is a tab \t . " + 
            //    "This is a \"quote\". " +
            //    "This is a backslash\\ " + 
            //    "This is a \n new line. " + 
            //    "And this is a bell. \a");


            //Problem 3
            string firstPerson = "Joe";
            string secPerson = "Jane";

            //if (firstPerson == secPerson)
            //{
            //    Console.WriteLine("The names are the same.");
            //}

            //else
            //{
            //    Console.WriteLine("The names are different.");
            //}


            //or

            //if (firstPerson.Equals(secPerson))
            //{
            //    Console.WriteLine("The names are the same.");
            //}

            //else
            //{
            //    Console.WriteLine("The names are different.");
            //}



            ////Problem 4
            //Console.WriteLine("Please enter your first name");
            //string firstName = Console.ReadLine();

            //Console.WriteLine("Please enter your last name");
            //string lastName = Console.ReadLine();

            //Console.WriteLine(firstName + " " + lastName);

            ////pt2 is not supposed to work....you can't concatenate using .Equals()




            //Problem 5
            Console.WriteLine("What kind of pet is the opposite of a dog?");
            string answer = Console.ReadLine().ToLower();

            if (answer == "cat")
            {
                Console.WriteLine("You guessed correctly!");
            }
            else if (answer == "meow") 
            {
                Console.WriteLine("You guessed correctly!");
            }
            else
            {
                Console.WriteLine("You are incorrect.");
            }





        }
    }
}
