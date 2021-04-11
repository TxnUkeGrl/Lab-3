using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
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
                Console.WriteLine("Would you like to go again " + EntryName + "? Press \"Y\" to continue!");
            }
            while (Console.ReadLine().ToLower() == "y");

            Console.WriteLine("Thanks for playing " + EntryName + "! See ya next time, BYE!");
        }

    }

}

