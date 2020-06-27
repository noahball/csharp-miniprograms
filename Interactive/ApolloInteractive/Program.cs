using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApolloInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's your name? : "); // Write text, do not skip a line so the user's input appears next to this text
            string name = Console.ReadLine(); // Grabs user input and stores it in a variable
            Console.Write("How old are you? : ");
            string age = Console.ReadLine();
            Console.WriteLine("Howdy, " + name + "! You are currently " + age + " years old."); // Print variables

            Console.ReadLine();
        }
    }
}
