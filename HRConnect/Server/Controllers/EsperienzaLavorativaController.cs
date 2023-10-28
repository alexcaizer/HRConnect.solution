using HRConnect.Server.Repository;
using HRConnect.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRConnect.Server.Controllers
{

    [ApiController]
    [Route("api/esperienzalavorativa")]
    public class EsperienzaLavorativaController : ControllerBase
    {
        private IEsperienzaLavorativaRepository _esperienzalavorativaRepository;
        public EsperienzaLavorativaController(IEsperienzaLavorativaRepository esperienzalavorativaRepository)
        {
            _esperienzalavorativaRepository = esperienzalavorativaRepository;
        }

        [HttpGet("Lista")]
        public ActionResult<IEnumerable<EsperienzaLavorativa>> GetAllEsperienzeLavorative()
        {
            return _esperienzalavorativaRepository.GetAllEsperienzeLavorative().ToList();
        }
        [HttpDelete("{id}")]
        public void DeleteEsperienzaLavorativa(int id)
        {
            _esperienzalavorativaRepository.DeleteEsperienzaLavorativa(id);
        }

        [HttpPost("Add")]
        public ActionResult AddEsperienzaLavorativa([FromBody] EsperienzaLavorativa nuovoEsperienzaLavorativa)
        {
            if (nuovoEsperienzaLavorativa == null)
            {
                return BadRequest("I dati del candidato sono incompleti.");
            }
            _esperienzalavorativaRepository.AddEsperienzaLavorativa(nuovoEsperienzaLavorativa);
            return Ok();
        }

        [HttpPut("Aggiorna")]
        public ActionResult<EsperienzaLavorativa> UpdateEsperienzaLavorativa(int id, EsperienzaLavorativa esperienzalavorativa)
        {
            return _esperienzalavorativaRepository.UpdateEsperienzaLavorativa(id, esperienzalavorativa);
        }


    }
}
