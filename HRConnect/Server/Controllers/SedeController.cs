using HRConnect.Server.Repository;
using HRConnect.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRConnect.Server.Controllers
{

    [ApiController]
    [Route("api/sede")]
    public class SedeController : ControllerBase
    {
        private ISedeRepository _sedeRepository;
        public SedeController(ISedeRepository sedeRepository)
        {
            _sedeRepository = sedeRepository;
        }

        [HttpGet("Lista")]
        public ActionResult<IEnumerable<Sede>> GetAllSedi()
        {
            return _sedeRepository.GetAllSedi().ToList();
        }
        [HttpDelete("{id}")]
        public void DeleteSede(int id)
        {
            _sedeRepository.DeleteSede(id);
        }

        [HttpPost("Add")]
        public ActionResult AddSede([FromBody] Sede nuovoSede)
        {
            if (nuovoSede == null)
            {
                return BadRequest("I dati della sede sono incompleti.");
            }
            _sedeRepository.AddSede(nuovoSede);
            return Ok();
        }

        [HttpPut("Aggiorna")]
        public ActionResult<Sede> UpdateSede(int id, Sede sede)
        {
            return _sedeRepository.UpdateSede(id, sede);
        }


    }
}
