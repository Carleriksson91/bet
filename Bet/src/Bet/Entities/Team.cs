using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bet.Entities
{
    public class Team
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Points { get; set; }

        public ICollection<Player> Players { get; set; }

        public ICollection<TeamGame> TeamGames { get; set; }

        public bool HomeTeam { get; set; }
    }
}
