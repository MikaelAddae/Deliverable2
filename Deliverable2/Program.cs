using System;

namespace Deliverable2
    //pre course deliverable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the coin flip challenge!");
            Console.WriteLine("What is your name?");

            //capture name as a string variable 
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + " Would you like to do the coin flip challenge? (Yes/No))");

            //capture answer as a string variable, make all characters lower case
            string answer = Console.ReadLine().ToLower();

            //compares answer to pre-defined values
            if (answer == "no")
            {
                Console.WriteLine("You are a coward " + name);
            }
            if (answer == "yes")
            {
                //variables for number of correct guesses, and number of flips
                int count = 0;
                int correct = 0;

                //C# random number variable
                Random rnd = new Random();

                //loop that repeats until 5 flips have occurred
                do
                {
                    Console.WriteLine("Heads or Tails?");
                    string choice = Console.ReadLine().ToLower();
                    bool flip = (choice == "heads");
                    //random number between 0(inclusive) and 2(exclusive), assigned 0 to heads, and 1 to tails
                    int result = rnd.Next(0, 2);
                    if (result == 1)
                    {
                        Console.WriteLine("Tails!");
                        count = count + 1;

                        {
                            if (flip == false && choice == "tails")
                            {
                                correct = correct + 1;
                            }
                        }
                    }

                    else if (result == 0)
                    {
                        Console.WriteLine("Heads!");
                        count = count + 1;

                        {
                            if (flip == true && choice == "heads")
                            {
                                correct = correct + 1;
                            }

                        }
                    }
                }
                while (count < 5);
                {
                    Console.WriteLine("Thank you " + name + "! You were correct (" + correct + "/5).");
                }
            }
        }
    }
}
