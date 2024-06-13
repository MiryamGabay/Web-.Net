using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Entities;

namespace Solid.Core.Repositories
{
    public interface ITurnRepositories
    {
        IEnumerable<Turn> GetTurns();

        Turn GetTurnById(int id);

        Turn AddTurn(Turn newTurn);

        Turn UpdateTurn(int i, Turn newTurn);

        void DeleteTurn(int i);

    }
}
