using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bet.Entities
{
    public class Stadium
    {
        public Guid Id { get; set; }

        public string City { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}
