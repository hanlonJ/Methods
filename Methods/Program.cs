/* Author: Jared Hanlon
   Date: 1/29/2019
   Comments: This C# Console application code demonstrates the use of
              methods after getting input from a user. The program has one
              method.
*/

using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please type your name: ");
            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();             
                Recommend_Name(input);
            } // End of try
            catch
            {
                Console.WriteLine("There was a problem processing that input...");
                Console.WriteLine("Please press any key to exit the program and try again...");
                // Pause the program and await the user to press a key to end the program
                Console.ReadKey(true); 
            } // End of catch
        } // End of main
        private static void Recommend_Name(string get_name)
        {
            // Response to the user entering their name
            Console.WriteLine(" ");           
            Console.WriteLine("Hello " + get_name + "!");
            Console.ReadKey(true);          
        } // End of method
    } // End of class
} // End of namespace
