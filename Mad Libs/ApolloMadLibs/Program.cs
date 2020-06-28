using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApolloMadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            string colour, pluralNoun, celebrity;

            Console.Write("Please choose a colour: ");
            colour = Console.ReadLine();

            Console.Write("Please enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Please enter a celebrity's name: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + colour);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I Love " + celebrity);

            Console.ReadLine();
        }
    }
}
