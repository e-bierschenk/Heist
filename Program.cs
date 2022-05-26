using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Crew crew = new Crew();
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
            try
            {
                Console.WriteLine($"There are {crew.CrewList.Count} members in your crew:\n");
                foreach (Crony crony in crew.CrewList)
                {
                    Console.WriteLine(crony);
                }
            }
            catch
            {
                Console.WriteLine("There is no one in your crew... :(");
            }
        }
    }
}
