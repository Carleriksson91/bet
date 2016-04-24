using Bet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bet.Entities
{
    public class Bet
    {
        public DateTime Date { get; set; }

        public Guid ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public Guid GameId { get; set; }
        public Game Game { get; set; }


    }
}
