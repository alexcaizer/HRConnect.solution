using HRConnect.Server.Repository;
using HRConnect.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRConnect.Server.Controllers
{
    [ApiController]
    [Route("api/candidati")]
    public class CandidatiController : ControllerBase
    {
        private ICandidatoRepository _candidatoRepository;
        public CandidatiController(ICandidatoRepository candidatoRepository)
        {
            _candidatoRepository = candidatoRepository;
        }

        [HttpGet("Lista")]
        public ActionResult<IEnumerable<Candidato>> GetAllCandidati()
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
