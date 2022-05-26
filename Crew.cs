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
    }
}