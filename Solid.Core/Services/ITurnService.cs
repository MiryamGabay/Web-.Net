using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface ITurnService
    {
        IEnumerable<Turn> GetAllTurn();

        Turn GetTurnByID(int id);

        Turn AddTurn(Turn newTurn);

        Turn UpdateTurn(int id, Turn newTurn);

        void DeleteTurn(int i);
    }
}
