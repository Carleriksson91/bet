using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bet.Entities
{
    public class TeamGame
    {
        public Guid TeamId { get; set; }
        public Team Team { get; set; }

        public Guid GameId { get; set; }
        public Game Game { get; set; }
    }
}
