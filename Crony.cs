using System;

namespace Heist
{
    public class Crony
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public decimal CourageFactor { get; set; }

        public Crony (string name, int skill, decimal courage)
        {
            Name = name;
            SkillLevel = skill;
            CourageFactor = courage;
        }

        public override string ToString()
        {
            return $"          Name: {Name} \n   Skill Level: {SkillLevel}\nCourage Factor: {CourageFactor}";
        }
    }
}