using HRConnect.Server.Repository;
using HRConnect.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRConnect.Server.Controllers
{

    [ApiController]
    [Route("api/mansione")]
    public class MansioneController : ControllerBase
    {
        private IMansioneRepository _mansioneRepository;
        public MansioneController(IMansioneRepository mansioneRepository)
        {
            _mansioneRepository = mansioneRepository;
        }

        [HttpGet("Lista")]
        public ActionResult<IEnumerable<Mansione>> GetAllMansioni()
        {
            return _mansioneRepository.GetAllMansioni().ToList();
        }
        [HttpDelete("{id}")]
        public void DeleteMansione(int id)
        {
            _mansioneRepository.DeleteMansione(id);
        }

        [HttpPost("Add")]
        public ActionResult AddMansione([FromBody] Mansione nuovoMansione)
        {
            if (nuovoMansione == null)
            {
                return BadRequest("I dati della mansione sono incompleti.");
            }
            _mansioneRepository.AddMansione(nuovoMansione);
            return Ok();
        }

        [HttpPut("Aggiorna")]
        public ActionResult<Mansione> UpdateMansione(int id, Mansione mansione)
        {
            return _mansioneRepository.UpdateMansione(id, mansione);
        }


    }
}
