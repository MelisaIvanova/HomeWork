using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Team
    {
        public Coach? Coach { get; set; }
        public List<Football_player>? Players { get; set; }
        public double AverageAge()
        {
            int totalAge = 0;
            foreach (var player in Players)
            {
                totalAge += player.Age;
            }
            return(double)totalAge/Players.Count();
        }


    }
}
