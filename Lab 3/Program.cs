using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        /*Task: Use conditional statements to automate the decision-making process.
            What will the application do?
                ● 1 Point: The application prompts to the user to enter an integer between 1 and 100.
                ● The application displays the associated result based on the integer range entered.
            Build Specifications:
                ● 1 Point: Use if/else statements to make different actions depending on user input.
                ● Given an integer entered by a user, perform the following conditional actions:
                    ○ 1 Point: If the integer is odd, print the number entered and “Odd.”
                    ○ 1 Point: If the integer entered is even and in the inclusive range of 2 to 25, print “Even and less than 25.”
                    ○ 1 Point: If the integer entered is even and in the inclusive range of 26 to 60, print “Even.”
                    ○ 1 Point: If the integer entered is even and greater than 60, print the number entered and “Even”.
                    ○ 1 Point: If the integer entered is odd and greater than 60, print the number entered and “Odd.”
            Additional Requirements:
                ● 1 Point: For answering Lab Summary when submitting to the LMS
                ● -2 Points: if there are any syntax errors or if the program does not run (for example, in a Main method).
            Extended Exercises (2 points maximum):
                ● 1 Point: Include a set of parameters so that the program ends officially.
                ● 1 Point: Ask for user information (ex. name) at the beginning of the application, and use it to refer to the user 
                           throughout the application.
                ● 1 Point: Add validation to guarantee that a user enters a positive integer between 1 and 100.
        */
        {
            Console.WriteLine("Hello User! What is your name?");
            string EntryName = Console.ReadLine();
            Console.WriteLine("Hi " + EntryName + "! Please enter a number between 1 and 100.");

            bool Again = true;

            do
            {
                if (Again != true)
                {
                    Console.WriteLine("Okay " + EntryName + "! Pick another number between 1 and 100.");
                }
                Again = false;

                uint EntryNumber;
                uint.TryParse(Console.ReadLine(), out EntryNumber);

                if (EntryNumber > 100)
                {
                    Console.WriteLine("Hey " + EntryName + ", I asked for a number between 1 and 100. I even said PLEASE!");
                }
                else if ((EntryNumber % 2) != 0 && (EntryNumber) > 60)
                {
                    Console.WriteLine(EntryNumber + " Odd. Interesting " + EntryName + ".");
                }
                else if ((EntryNumber % 2) != 0)
                {
                    Console.WriteLine(EntryNumber + " Odd. Okay " + EntryName + "!");
                }
                else if ((EntryNumber % 2) == 0 && (EntryNumber) >= 2 && (EntryNumber) <= 25)
                {
                    Console.WriteLine("Even and less than 25. Thanks " + EntryName + ".");
                }
                else if ((EntryNumber % 2) == 0 && (EntryNumber) >= 26 && (EntryNumber) <= 60)
                {
                    Console.WriteLine("Even. Awesome " + EntryName);
                }
                else if ((EntryNumber % 2) == 0 && (EntryNumber) > 60)
                {
                    Console.WriteLine(EntryNumber + " Even. Cool beans " + EntryName + "!");
                }
                else
                {
                    Console.WriteLine("Yeeaaa.......noooo......that's not gonna work " + EntryName + ". GG.");
                    //Console.ReadLine();
                }
                Console.WriteLine("Would you like to go again " + EntryName + "? (y/n)");
            }
            while (Console.ReadLine().ToLower() == "y");

            Console.WriteLine("Thanks for playing " + EntryName + "! See ya next time, BYE!");
        }

    }

}

