using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Crew crew = new Crew();
            Bank bank = new Bank();
            Console.WriteLine("Plan your heist!");
            while (true)
            {
                Console.Write("Enter your Crony's name: ");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
                Console.Write("What is their skill level (positive integer)?: ");
                int skill = int.Parse(Console.ReadLine());
                Console.Write("What is their courage factor (decimal 0.0 - 2.0)?: ");
                decimal courage = Decimal.Parse(Console.ReadLine());

                Crony crony = new Crony(name, skill, courage);
                crew.CrewList.Add(crony);
            }

            Console.Write("How many times would you like to run the simulation?: ");
            int trials = int.Parse(Console.ReadLine());

            for (int i = 0; i < trials; i++)
            {
                int luck = new Random().Next(-10, 11);
                bank.Difficulty += luck;

                Console.WriteLine($"\nYour crew has {crew.GetCrewSkill()} skill.");
                Console.WriteLine($"Look out, the bank has a difficulty rating of {bank.Difficulty}.\n");
                if (crew.GetCrewSkill() >= bank.Difficulty)
                {
                    Console.WriteLine("This...crew...is...good. Great success!");
                }
                else
                {
                    Console.WriteLine("You did not do it. Your crew is dead.");
                }
            }
        }
    }
}
