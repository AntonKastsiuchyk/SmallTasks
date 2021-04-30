using AirportSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportSimulation.AirportServices
{
    sealed class CheckBag
    {
        public static int CheckWeightOfBag(Bag bag)
        {
        startloop:
            string answer = Console.ReadLine();
            answer.ToUpper();

            if (answer.Equals("yes"))
            {
                Console.WriteLine("Please place your bag on the scale. (any key)");
                Console.ReadKey();
                Random random = new Random();
                bag.Weight = random.Next(1, 100);
                Console.WriteLine("Weight of your luggage is: " + bag.Weight.ToString());
                CheckBag.CheckOverweight(bag);
            }
            else if (answer.Equals("no"))
            {
                Console.WriteLine("Alright. Please answer next question.");
            }
            else
            {
                Console.WriteLine("Sorry, i dont understand your understrike. Do you have any luggage?");
                goto startloop;
            }
            return bag.Weight;
        }

        static int CheckOverweight(Bag bag)
        {
            if (bag.Weight >= Constants.Const.MaxWeightOfBag)
            {
                Console.WriteLine("You luggage is overweight. I’m afraid, you’ll have to pay for excess luggage. Are you want to pay for it?(yes or no)");
                string answer = Console.ReadLine();
                answer.ToUpper();

            startloop:
                if (answer.Equals("yes"))
                {
                    Console.WriteLine("Thank you. Please answer next question.");
                }
                else if (answer.Equals("no"))
                {
                    Console.WriteLine("Please decide, what you want to do with your baggage and return here.");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Sorry, i dont understand your understrike, try again (yes or no).");
                    goto startloop;
                }
            }
            else
            {
                Console.WriteLine("You dont have excess luggage.");
            }
            return bag.Weight;
        }
    }
}
