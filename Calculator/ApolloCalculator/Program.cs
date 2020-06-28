using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApolloCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The Grand Calculator\nPlease enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The answer to " + num1 + "+" + num2 + " is " + (num1 + num2));
            Console.ReadLine();
        }
    }
}
