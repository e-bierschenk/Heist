using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");
            Console.Write("Enter your Crony's name: ");
            string name = Console.ReadLine();
            Console.Write("What is their skill level (positive integer)?: ");
            int skill = int.Parse(Console.ReadLine());
            Console.Write("What is their courage factor (decimal 0.0 - 2.0)?: ");
            decimal courage = Decimal.Parse(Console.ReadLine());

            Crony crony = new Crony(name, skill, courage);
            Console.WriteLine(crony);
        }
    }
}
