using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> Figures = new List<Team>();
            Team JamesandBrian = new Team("Munster", "Home: Thomand", 25000, 150000, "Roster", "James Jackson €100,000", "Brian Kavanagh €50,000");
            Team SeanandKevin = new Team("Sligo Rovers", "Home: The Showgrounds", 3000, 350000, "Roster", "Sean Quinn €100,000", "Kevin Beirne €150,000");

            Figures.Add(JamesandBrian);
            Figures.Add(SeanandKevin);
        }
    }
}
