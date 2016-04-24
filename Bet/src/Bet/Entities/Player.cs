using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bet.Entities
{
    public class Player
    {
        public Guid Id { get; set; }

        public string Firstname { get; set; }

        public string Surname { get; set; }

        public int Number { get; set; }


    }
}
