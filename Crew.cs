using System;
using System.Collections.Generic;

namespace Heist
{
    public class Crew
    {
        public List<Crony> CrewList { get; set; }
        public Crew()
        {
            CrewList = new List<Crony>();
        }

        public void PrintCrew()
        {
            Console.WriteLine($"There are {CrewList.Count} members in your crew:\n");
            foreach (Crony crony in CrewList)
            {
                Console.WriteLine(crony);
            }
        }

        public int GetCrewSkill()
        {
            int skill = 0;
            foreach (Crony member in CrewList)
            {
                skill += member.SkillLevel;
            }

            return skill;
        }
    }
}