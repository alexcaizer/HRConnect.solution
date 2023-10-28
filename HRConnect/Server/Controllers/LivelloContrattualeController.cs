using HRConnect.Server.Repository;
using HRConnect.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRConnect.Server.Controllers
{

    [ApiController]
    [Route("api/livellocontrattuale")]
    public class LivelloContrattualeController : ControllerBase
    {
        private ILivelloContrattualeRepository _livellocontrattualeRepository;
        public LivelloContrattualeController(ILivelloContrattualeRepository livellocontrattualeRepository)
        {
            _livellocontrattualeRepository = livellocontrattualeRepository;
        }

        [HttpGet("Lista")]
        public ActionResult<IEnumerable<LivelloContrattuale>> GetAllLivelliContrattuali()
        {
            return _livellocontrattualeRepository.GetAllLivelliContrattuali().ToList();
        }
        [HttpDelete("{id}")]
        public void DeleteLivelloContrattuale(int id)
        {
            _livellocontrattualeRepository.DeleteLivelloContrattuale(id);
        }

        [HttpPost("Add")]
        public ActionResult AddLivelloContrattuale([FromBody] LivelloContrattuale nuovoLivelloContrattuale)
        {
            if (nuovoLivelloContrattuale == null)
            {
                return BadRequest("I dati del candidato sono incompleti.");
            }
            _livellocontrattualeRepository.AddLivelloContrattuale(nuovoLivelloContrattuale);
            return Ok();
        }

        [HttpPut("Aggiorna")]
        public ActionResult<LivelloContrattuale> UpdateLivelloContrattuale(int id, LivelloContrattuale livellocontrattuale)
        {
            return _livellocontrattualeRepository.UpdateLivelloContrattuale(id, livellocontrattuale);
        }


    }
}
