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
            //Problem 1
            string firstName = "Ali";
            string lastName = "Ware";

            Console.WriteLine(firstName.Length);
            Console.WriteLine(lastName.Length);

            if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("First is longer.");
            }
            else if (firstName.Length == lastName.Length)
            {
                Console.WriteLine("Sameses!");
            }
            else
            {
                Console.WriteLine("Last must be longer!");
            }
        }
    }
}
