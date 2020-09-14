/* 
    Author: Valentina Delgado-Rodriguez
    Date: 09/14/2020
    Comments: This C# console demonstrates the use of a For loop
              after getting input from users. 
*/

using System;

namespace Iteration_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a message to the user asking them in enter a value from 1 to 25
            Console.Write("Enter an integer value between 1 and 25 to execute an iterative statement: ");
            
            // Try-catch used to display a message if a user inputs words or a number larger than 25 or smaller than 1
            try
            {
                // Declared a variable that will store the number that the user enters
                string input = Console.ReadLine();
                
                // Change the string input variable into an integer to be used in if statements
                int value_input = int.Parse(input);

                // If the number the user inputs is greater than 0 and less than or equal to 25
                // then the For loop will begin
                if ((value_input > 0) && (value_input <= 25))
                {
                    // If a number is between 1 and 25 display this message letting the user know
                    // that we are using a For loop
                    Console.WriteLine("Executing a For Loop!");
                    
                    // Once the number the user enters passed the test, this For loop will begin
                    // that will display a message a certain number of times depending on what the user enters
                    for (int i = 1; value_input >= i; i++)
                    {
                        Console.WriteLine("You have entered " + value_input.ToString() + ". " + "This is the current integer value in the loop: " + i.ToString());
                    }

                } // end of if statement
              
                // If the user does not input a number between 1 and 25, display this message
                else
                {
                    Console.WriteLine("Please enter an integer from 1 to 25 and try again...");
                    Console.WriteLine("Press any key to exit the program...");
                    // This will pause the program to wait for the user to press any key to start the program again
                    Console.ReadKey(true);
                }

            } //end of try

            //Try-catch used to display a message if a user inputs words or a number larger than 25 or smaller than 1
            catch
            {
                Console.WriteLine("Please enter an integer from 1 to 25 and try again...");
                Console.WriteLine("Press any key to exit the program...");
                // This will pause the program to wait for the user to press any key to start the program again
                Console.ReadKey(true);

            } //end of catch
        } //end of main
    } //end of class
} // end of namespace
