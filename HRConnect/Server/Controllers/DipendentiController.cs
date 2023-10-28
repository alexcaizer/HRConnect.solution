using HRConnect.Server.Repository;
using HRConnect.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRConnect.Server.Controllers
{
    [ApiController]
    [Route("api/dipendente")]
    public class DipendentiController : ControllerBase
    {
        private IDipendenteRepository _dipendenteRepository;
        public DipendentiController(IDipendenteRepository dipendenteRepository)
        {
            _dipendenteRepository = dipendenteRepository;
        }

        [HttpGet("Lista")]
        public ActionResult<IEnumerable<Dipendente>> GetAllDipendenti() {
            return _dipendenteRepository.GetAllDipendenti().ToList();
        }
        [HttpDelete("{id}")]
        public void DeleteDipendente(int id)
        {
            _dipendenteRepository.DeleteDipendente(id);
        }

        [HttpPost("Add")]
        public ActionResult AddDipendente([FromBody] Dipendente nuovoDipendente)
        {
            if(nuovoDipendente == null)
            {
                return BadRequest("I dati del dipendenti sono incompleti.");
            }
             _dipendenteRepository.AddDipendente(nuovoDipendente);
            return Ok();
        }

        [HttpPut("Aggiorna")]
        public ActionResult<Dipendente> UpdateDipendente(int id, Dipendente dipendente)
        { 
           return _dipendenteRepository.UpdateDipendente(id, dipendente);
        }

       
    }
}
