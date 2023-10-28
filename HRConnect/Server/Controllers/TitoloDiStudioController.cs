using HRConnect.Server.Repository;
using HRConnect.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRConnect.Server.Controllers
{

    [ApiController]
    [Route("api/titolidistudio")]
    public class TitoloDiStudioController : ControllerBase
    {
        private ITitoloDiStudioRepository _titolodistudioRepository;
        public TitoloDiStudioController(ITitoloDiStudioRepository titolodistudioRepository)
        {
            _titolodistudioRepository = titolodistudioRepository;
        }

        [HttpGet("Lista")]
        public ActionResult<IEnumerable<TitoloDiStudio>> GetAllTitoliDiStudio()
        {
            return _titolodistudioRepository.GetAllTitoliDiStudio().ToList();
        }
        [HttpDelete("{id}")]
        public void DeleteTitoloDiStudio(int id)
        {
            _titolodistudioRepository.DeleteTitoloDiStudio(id);
        }

        [HttpPost("Add")]
        public ActionResult AddTitoloDiStudio([FromBody] TitoloDiStudio nuovoTitoloDiStudio)
        {
            if (nuovoTitoloDiStudio == null)
            {
                return BadRequest("I dati del titolo sono incompleti.");
            }
            _titolodistudioRepository.AddTitoloDiStudio(nuovoTitoloDiStudio);
            return Ok();
        }

        [HttpPut("Aggiorna")]
        public ActionResult<TitoloDiStudio> UpdateTitoloDiStudio(int id, TitoloDiStudio titolodistudio)
        {
            return _titolodistudioRepository.UpdateTitoloDiStudio(id, titolodistudio);
        }


    }
}
