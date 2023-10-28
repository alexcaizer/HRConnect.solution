using HRConnect.Server.Repository;
using HRConnect.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRConnect.Server.Controllers
{

    [ApiController]
    [Route("api/colloquio")]
    public class ColloquioController : ControllerBase
    {
        private IColloquioRepository _colloquioRepository;
        public ColloquioController(IColloquioRepository colloquioRepository)
        {
            _colloquioRepository = colloquioRepository;
        }

        [HttpGet("Lista")]
        public ActionResult<IEnumerable<Colloquio>> GetAllColloqui()
        {
            return _colloquioRepository.GetAllColloqui().ToList();
        }
        [HttpDelete("{id}")]
        public void DeleteColloquio(int id)
        {
            _colloquioRepository.DeleteColloquio(id);
        }

        [HttpPost("Add")]
        public ActionResult AddColloquio([FromBody] Colloquio nuovoColloquio)
        {
            if (nuovoColloquio == null)
            {
                return BadRequest("I dati del colloquio sono incompleti.");
            }
            _colloquioRepository.AddColloquio(nuovoColloquio);
            return Ok();
        }

        [HttpPut("Aggiorna")]
        public ActionResult<Colloquio> UpdateColloquio(int id, Colloquio colloquio)
        {
            return _colloquioRepository.UpdateColloquio(id, colloquio);
        }


    }
}
