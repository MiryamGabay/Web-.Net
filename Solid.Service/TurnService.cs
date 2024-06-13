using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class TurnService : ITurnService
    {
        public readonly ITurnRepositories _turnRepositories;

        public TurnService(ITurnRepositories turnRepositories)
        {
            _turnRepositories = turnRepositories;
        }

        public IEnumerable<Turn> GetAllTurn()
        {
            return _turnRepositories.GetTurns();
        }

        public Turn GetTurnByID(int id)
        {
            return _turnRepositories.GetTurnById(id);
        }

        public Turn AddTurn(Turn newTurn)
        {
            return _turnRepositories.AddTurn(newTurn);
        }

        public Turn UpdateTurn(int id, Turn newTurn)
        {
            return _turnRepositories.UpdateTurn(id, newTurn);
        }

        public void DeleteTurn(int i)
        {
            _turnRepositories.DeleteTurn(i);
        }
    }
}
