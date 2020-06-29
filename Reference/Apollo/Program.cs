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

            Console.WriteLine("-- STRINGS --\n"); // Print text with a line break
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

            int num = 6;
            num++; // Add 1 to the integer.

            Console.WriteLine("\n-- NUMBERS --\n");
            Console.WriteLine(5); // Print whole number
            Console.WriteLine(-5.783); // Print a negative/decimal number
            Console.WriteLine(5 + 8); // Simple maths (addition)
            Console.WriteLine(4 - 2); // Simple maths (subtraction)
            Console.WriteLine(12 * 3); // Simple maths (multiplication)
            Console.WriteLine(5 % 2); // Remainder (divison). Eg. 2 goes into 5 2 times, then you have a remainder of 1 that couldn't go into 5.
            Console.WriteLine(4 + 2 * 3); // BEDMAS (Order of operations). Computer works out 2 x 3 (=6), then works out 4 + 6 (=10) 
            Console.WriteLine((4 + 2) * 3); // Override standard BEDMAS rules. Computer works out 4 + 2 (=6), then times it by 3 - final equation is 6 x 3.
            Console.WriteLine(5.0 + 8.1); // Addition with decimals
            Console.WriteLine(5 + 8.1); // Also works, however since you have included both an integer and a double, a double will be returned.
            Console.WriteLine(5 / 2); // Division. Since you have inputted integers, not doubles the result will be a roudned integer. Normal result if it was a double would be extremely long.
            Console.WriteLine(5 / 2.0); // You see here. how you recieve a double, which is more precise as you presented the computer with a double - instead of an integer.
            Console.WriteLine(num); // Printing an integer
            Console.WriteLine(num + 2); // Addition with a variable
            Console.WriteLine(Math.Abs(-40)); // Methods. In this case it returns an absolute value, which is 40.
            Console.WriteLine(Math.Pow(2, 3)); // Powers of.
            Console.WriteLine(Math.Pow(3.8, 2)); // Powers of with decimals/doubles.
            Console.WriteLine(Math.Sqrt(36)); // Square roots
            Console.WriteLine(Math.Max(3, 67)); // Print out the larger number/integer
            Console.WriteLine(Math.Min(3, 67)); // Print out the smaller number/integer
            Console.WriteLine(Math.Round(4.3)); // Rounding numbers

            // Console.WriteLine("\n-- USER INPUT --\n");
            // Console.Write("What's your name? : "); // Write text, do not skip a line so the user's input appears next to this text
            // string interactiveName = Console.ReadLine(); // Grabs user input and stores it in a variable
            // Console.Write("How old are you? : ");
            // string interactiveAge = Console.ReadLine();
            // Console.WriteLine("Howdy, " + interactiveName + "! You are currently " + interactiveAge + " years old."); // Print variables

            Console.WriteLine("\n-- ARRAYS --\n");
            int[] luckyNumbers = {4, 8 , 15, 16 , 23, 42}; // Defining an array
            luckyNumbers[2] = 97; // Changing a value from an array
            string[] friends = new string[3]; // Create an array, and define the max amount of values it can hold. Be aware that this value includes the value 0. Meaning that if you defined 3 as the max value, you can only define values 0, 1 and 2 later. If you attempted to define value 3, the program would crash.
            friends[0] = "Dj Stores";
            friends[1] = "KingNick";
            friends[2] = "Munchie";

            Console.WriteLine(luckyNumbers[2]); // Print a value from an array

            Console.WriteLine("\n-- Methods --\n");

            ExampleMethod("blue", "orange"); // Call a method, and pass parameters.
            ExampleMethod("red", "banana"); // You can run methods as many times as you want!

            Console.WriteLine(num + " cubed is equal to " + Cube(5) + "!");

            Console.WriteLine("\n\nProgram executed successfully.");
            Console.ReadLine(); // Show console lines until enter or a character is pressed. Without this the program will terminate immediately.
        }

        static void ExampleMethod(string colour, string fruit) // Create a method, and accept a parameter
        {
            Console.WriteLine("This is a method!"); // Printing text, just like in the main method!
            Console.WriteLine("This method's favourite colour is " + colour + ", and the " + fruit + " is its favourite fruit!"); // Use a paramater passed when calling the method
        }

        static int Cube(int num) // Method accepting parameters and returning an integer
        {
            int result = num * num * num; // Creating a new integer called result, which takes the parameter num passed to the method, and cubes it.
            return result; // The method returns an integer, in this case the pre-defined integer result
        }

    }
}
