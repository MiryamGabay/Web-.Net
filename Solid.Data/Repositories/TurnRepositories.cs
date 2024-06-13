using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;
using Solid.Core.Repositories;


namespace Solid.Data.Repositories
{
    public class TurnRepositories : ITurnRepositories
    {
        private readonly DataContaxt _dataContaxt;

        public TurnRepositories(DataContaxt dataContaxt)
        {
            _dataContaxt = dataContaxt;
        }
        public IEnumerable<Turn> GetTurns()
        {
            return _dataContaxt.Turns.Include(t => t.Customer).Include(t => t.ServiceProviders).ToList();//.Include(t => t.Customer).ToList();
        }
        public Turn GetTurnById(int id)
        {
            return _dataContaxt.Turns.Include(t => t.Customer).Include(t => t.ServiceProviders).ToList().First(t => t.Id == id);//
        }
        public Turn AddTurn(Turn newTurn)
        {
            _dataContaxt.Turns.Add(newTurn);
            _dataContaxt.SaveChanges();
            return newTurn;
        }
        public Turn UpdateTurn(int i, Turn newTurn)
        {
            var oldTurn = GetTurnById(i);

            oldTurn.Date = newTurn.Date;
            oldTurn.SumHour = newTurn.SumHour;
            oldTurn.Type = newTurn.Type;
            oldTurn.NameServiceProvider = newTurn.NameServiceProvider;
            oldTurn.ServiceProvidersId = newTurn.ServiceProvidersId;
            oldTurn.NameServiceProvider = newTurn.NameServiceProvider;

            _dataContaxt.SaveChanges();
            return oldTurn;
        }
        public void DeleteTurn(int i)
        {
            var turn = GetTurnById(i);
            _dataContaxt.Turns.Remove(turn);
            _dataContaxt.SaveChanges();

        }
    }
}
