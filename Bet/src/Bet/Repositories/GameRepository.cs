using Bet.Entities;
using Bet.Interfaces;
using Bet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bet.Repositories
{
    public class GameRepository : IGameRepository
    {
        public IEnumerable<Game> GetAll()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Games.ToList();
            }
        }
    }
}
