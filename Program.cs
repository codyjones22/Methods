/* Author: Cody Jones
   Date: 2/4/21
   Comments: C# Console Application demonstrating the use of methods
                after retrieving user input.
*/
using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asking user to enter their name
            Console.WriteLine("Please enter your name.");
            // Applying try block to validate user input
            try
            {
                // This variable will gather user input
                string name = Console.ReadLine();
                // Parsing greeting with user's input
                Console.WriteLine("Hello {0}", name);
            }
            catch
            {
                Console.WriteLine("Please enter a lettered variable.");
                Console.WriteLine("Press any key to exit the program.");
                Console.ReadKey(true);
            }
        }
    }
}
