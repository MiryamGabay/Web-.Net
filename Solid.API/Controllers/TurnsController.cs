using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.API.Entites;
using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.Service;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("QueenBride/[controller]")]
    [ApiController]
    public class TurnsController : ControllerBase
    {
        private readonly ITurnService _turnService;
        private readonly IMapper _mapper;

        public TurnsController(ITurnService turnService,IMapper mapper)
        {
            _turnService = turnService;
            _mapper = mapper;
        }


        // GET: api/<TurnsController>
        [HttpGet]
        public ActionResult Get()
        {
            var turns = _turnService.GetAllTurn();
            var turnsDto = _mapper.Map<IEnumerable<Turn>>(turns);
            return Ok(turnsDto);
        }

        // GET api/<TurnsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var turn = _turnService.GetTurnByID(id);
            var turnDto = _mapper.Map<Turn>(turn);
            return Ok(turnDto);
        }

        // POST api/<TurnsController>
        [HttpPost]
        public ActionResult Post([FromBody] TurnPostEntite newTurn)
        {
            var turn = new Turn
            {
                Date = newTurn.Date,
                SumHour = newTurn.SumHour,
                Type = newTurn.Type,
                NameServiceProvider = newTurn.NameServiceProvider,
                ServiceProvidersId = newTurn.ServiceProvidersId,
                CustomerId = newTurn.CustomerId,
            };
            var tur = _turnService.AddTurn(turn);
            var turnDto = _mapper.Map<Turn>(tur);
            return Ok(turnDto);

        }

        // PUT api/<TurnsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] TurnPostEntite newTurn)
        {
            var turn = new Turn
            {
                Date = newTurn.Date,
                SumHour = newTurn.SumHour,
                Type = newTurn.Type,
                NameServiceProvider = newTurn.NameServiceProvider,
            };
            var tur = _turnService.UpdateTurn(id, turn);
            var turnDto = _mapper.Map<Turn>(tur);
            return Ok(turnDto);
        }

        // DELETE api/<TurnsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var turn = _turnService.GetTurnByID(id);
            if (turn is null)
                return NotFound();
            _turnService.DeleteTurn(id);
            return NoContent();
        }
    }
}
