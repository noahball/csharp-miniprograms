using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Apollo
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Cool Kids"; // Strings
            char grade = 'A'; // Chars (single letter)
            int age = 14; // Integers (full numbers)
            double gpa = 3.2; // Doubles (decimal numbers)
            bool isMale = true; // Booleans (true/false)
            string lookFor = "Kids";
            int firstInt = 6;
            int printPart = 2;
            int endPrintPart = 5;

            Console.WriteLine(phrase); // Write a line on the console - in this case a string (variable)
            Console.WriteLine("This is\nSkipping a line"); // Line breaks
            Console.WriteLine("This is \"\"\"Horrible\"\"\""); // Having quotation marks in a string
            Console.WriteLine("This is the " + phrase + " project, rated grade " + grade + "."); // Concatination, adding multiple variables into a string
            Console.WriteLine("The length of the phrase " + phrase + " is " + phrase.Length + " characters long."); // Get length of a string and display it in the console
            Console.WriteLine("The phrase " + phrase + " in uppercase is: " + phrase.ToUpper()); // Converts a string into uppercase - using the ToUpper() method
            Console.WriteLine("The phrase " + phrase + " in lowercase is: " + phrase.ToLower()); // Converts a string into lowercase - using the ToLower() method
            Console.WriteLine("The myth that the phrase " + phrase + " contains " + lookFor + " is " + phrase.Contains(lookFor) + ", the mystery is solved!"); // Implementation of everything I've learned so far, and using the Contains() method while passing arguments
            Console.WriteLine("The first character of the string " + phrase + " is " + phrase[0]); // Print the first character of a string
            Console.WriteLine("Character #" + firstInt + " of the string " + phrase + " is " + phrase[firstInt]); // Print a specific character from a string. In this case phrase is "Cool Kids" and firstInt is 6, the result will be i. Be aware that the first character is 0 NOT 1
            Console.WriteLine("The phrase " + lookFor + " of the string " + phrase + " starts at the position #" + phrase.IndexOf(lookFor)); // Print the position where a specific word in a string starts.
            Console.WriteLine("The string " + phrase + " trimmed to only display character #" + printPart + " and beyond is " + phrase.Substring(printPart)); // Only display a specific character of a string and beyond
            Console.WriteLine("The characters in positions " + printPart + "-" + endPrintPart + " in the string " + phrase + " are " + phrase.Substring(printPart, endPrintPart)); // Display specific characters from a string in a specific range

            Console.WriteLine("Program executed successfully.");
            Console.ReadLine(); // Show console lines until enter or a character is pressed. Without this the program will terminate immediately.
        }
    }
}
