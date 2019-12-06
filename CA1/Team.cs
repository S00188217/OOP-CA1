using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Team
    {
        public string Name { get; set; }
        public string Home { get; set; }
        public int GroundCapacity { get; set; }
        public int TeamValue { get; set; }
        public string Roster { get; set; }
        public string Player1 { get; set; }
        public string Player2 { get; set; }

        public List<Team> Figures { get; set; }
        public Team(string name, string home, int groundCapacity, int teamValue, string roster, string player1, string player2)
        {
            Name = name;
            Home = home;
            GroundCapacity = groundCapacity;
            TeamValue = teamValue;
            Roster = roster;
            Player1 = player1;
            Player2 = player2;
            Figures = new List<Team>();
        }


        public Team(string name, string home, int groundCapacity, int teamValue, string roster, string player1, string player2) : this(name, home, 0, 0, roster, player1, player2)
        {

        }
        public Team(string name) : this(name, home,)
        {

        }

        public string DisplayFigures()
        {
            return string.Format($"{Name,-15}{Home,-15}{GroundCapacity,-15}{TeamValue,-15}{Roster,-15}{Player1,-15}{Player2, -15}");
        }
    }

    class RugbyTeam
    {

    }

    class SoccerTeam
    {

    }
}
