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
            return _cittaRepository.GetAllCitta().ToList();
        }
        [HttpDelete("{id}")]
        public void DeleteCitta(int id)
        {
            _cittaRepository.DeleteCitta(id);
        }

        [HttpPost("Add")]
        public ActionResult AddCitta([FromBody] Citta nuovoCitta)
        {
            if (nuovoCitta == null)
            {
                return BadRequest("I dati della città sono incompleti.");
            }
            _cittaRepository.AddCitta(nuovoCitta);
            return Ok();
        }

        [HttpPut("Aggiorna")]
        public ActionResult<Citta> UpdateCitta(int id, Citta citta)
        {
            return _cittaRepository.UpdateCitta(id, citta);
        }


    }
}
