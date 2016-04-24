using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bet.Entities
{
    public class Game
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }

        public ICollection<TeamGame> TeamGames { get; set; }

        public int Attendance { get; set; }
    }
}
