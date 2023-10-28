using HRConnect.Server.Repository;
using HRConnect.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRConnect.Server.Controllers
{

    [ApiController]
    [Route("api/contratto")]
    public class ContrattoController : ControllerBase
    {
        private IContrattoRepository _contrattoRepository;
        public ContrattoController(IContrattoRepository contrattoRepository)
        {
            _contrattoRepository = contrattoRepository;
        }

        [HttpGet("Lista")]
        public ActionResult<IEnumerable<Contratto>> GetAllContratti()
        {
            return _contrattoRepository.GetAllContratti().ToList();
        }
        [HttpDelete("{id}")]
        public void DeleteContratto(int id)
        {
            _contrattoRepository.DeleteContratto(id);
        }

        [HttpPost("Add")]
        public ActionResult AddContratto([FromBody] Contratto nuovoContratto)
        {
            if (nuovoContratto == null)
            {
                return BadRequest("I dati del candidato sono incompleti.");
            }
            _contrattoRepository.AddContratto(nuovoContratto);
            return Ok();
        }

        [HttpPut("Aggiorna")]
        public ActionResult<Contratto> UpdateContratto(int id, Contratto contratto)
        {
            return _contrattoRepository.UpdateContratto(id, contratto);
        }


    }
}
