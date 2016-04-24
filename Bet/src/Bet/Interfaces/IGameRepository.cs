using Bet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bet.Interfaces
{
    public interface IGameRepository
    {
        IEnumerable<Game> GetAll();
    }
}
