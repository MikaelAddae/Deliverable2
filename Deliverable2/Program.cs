using System;

namespace Deliverable2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the coin flip challenge!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + " Would you like to do the coin flip challenge? (Yes/No))");
            string answer = Console.ReadLine().ToLower();
            if (answer == "no")
            {
                Console.WriteLine("You are a coward " + name);
            }
            if (answer == "yes") {
                int count = 0;
                int correct = 0;

                Random rnd = new Random();
                do
                {
                    Console.WriteLine("Heads or Tails?");
                    string choice = Console.ReadLine().ToLower();
                    bool flip = (choice == "heads");
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
                    { Console.WriteLine("Thank you " + name + "! You were correct (" + correct + "/5).");
                    }
             } 
        }
    }
}