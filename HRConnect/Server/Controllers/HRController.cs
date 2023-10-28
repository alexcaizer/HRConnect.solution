using HRConnect.Server.Repository;
using HRConnect.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRConnect.Server.Controllers
{

    [ApiController]
    [Route("api/hr")]
    public class HRController : ControllerBase
    {
        private IHRRepository _hrRepository;
        public HRController(IHRRepository hrRepository)
        {
            _hrRepository = hrRepository;
        }

        [HttpGet("Lista")]
        public ActionResult<IEnumerable<HR>> GetAllHR()
        {
            return _hrRepository.GetAllHR().ToList();
        }
        [HttpDelete("{id}")]
        public void DeleteHR(int id)
        {
            _hrRepository.DeleteHR(id);
        }

        [HttpPost("Add")]
        public ActionResult AddHR([FromBody] HR nuovoHR)
        {
            if (nuovoHR == null)
            {
                return BadRequest("I dati del HR sono incompleti.");
            }
            _hrRepository.AddHR(nuovoHR);
            return Ok();
        }

        [HttpPut("Aggiorna")]
        public ActionResult<HR> UpdateHR(int id, HR hr)
        {
            return _hrRepository.UpdateHR(id, hr);
        }


    }
}
