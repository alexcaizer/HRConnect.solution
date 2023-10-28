using HRConnect.Server.Repository;
using HRConnect.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRConnect.Server.Controllers
{

    [ApiController]
    [Route("api/citta")]
    public class CittaController : ControllerBase
    {
        private ICittaRepository _cittaRepository;
        public CittaController(ICittaRepository cittaRepository)
        {
            _cittaRepository = cittaRepository;
        }

        [HttpGet("Lista")]
        public ActionResult<IEnumerable<Citta>> GetAllCitta()
        {
            return _candidatoRepository.GetAllCandidati().ToList();
        }
        [HttpDelete("{id}")]
        public void DeleteCandidato(int id)
        {
            _candidatoRepository.DeleteCandidato(id);
        }

        [HttpPost("Add")]
        public ActionResult AddCandidato([FromBody] Candidato nuovoCandidato)
        {
            if (nuovoCandidato == null)
            {
                return BadRequest("I dati del candidato sono incompleti.");
            }
            _candidatoRepository.AddCandidato(nuovoCandidato);
            return Ok();
        }

        [HttpPut("Aggiorna")]
        public ActionResult<Candidato> UpdateCandidato(int id, Candidato candidato)
        {
            return _candidatoRepository.UpdateCandidato(id, candidato);
        }


    }
}
