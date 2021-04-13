using System;

namespace Classmates
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Sean", "Kalai", "Jean", "Justin", "Alice", "Jason", "Kristin", "Kamesha" };
            string[] cities = { "Plymouth", "Troy", "Lascahobas", "Wyoming", "Detroit", "Courtright", "Orange Park", "Detroit" };
            string[] food = { "Pizza", "Dosa", "Fritay", "Baja Blast", "Sushi", "Mac & Cheese", "Macaroni & Cheese", "Tacos" };

            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number 1-8): ");
            int stnum = int.Parse(Console.ReadLine());

            if (stnum == 1 || stnum == 2 || stnum == 3 || stnum == 4 || stnum == 5 || stnum == 6 || stnum == 7 || stnum == 8)
            {
                Console.WriteLine($"Student {stnum} is {names[stnum - 1]}.  What would you like to know about {names[stnum - 1]}? (enter 'hometown' or 'favourite food'):");
                string hf = (Console.ReadLine());

                bool RunProgram = true;
                while (RunProgram) 
                {
                    if (hf == "hometown")
                    {
                        Console.WriteLine($"{names[stnum - 1]} is from {cities[stnum - 1]}.  Would you like to know more? y/n");
                        RunProgram = false;                        
                        {
                            string yesno = Console.ReadLine();
                            if (yesno == "y")
                            {
                                break;
                            }
                            else if (yesno == "n")
                            {
                                RunProgram = false;
                                break;
                            }
                        }
                    }
                    else if (hf == "favourite food")
                    {
                        Console.WriteLine($"{names[stnum - 1]}'s favourite food is {food[stnum - 1]}.  Would you like to know more?");
                        RunProgram = false;
                        {
                            string yesno = Console.ReadLine();
                            if (yesno == "y")
                            {
                                break;
                            }
                            else if (yesno == "n")
                            {
                                RunProgram = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("That data does not exist.  Please try again. (enter 'hometown' or 'favourite food')");
                    }
                }
            }
            else
            {
                Console.WriteLine("That student does not exist.  Please try again.  (enter a number 1 - 8)");
            }
        }
    }
}






