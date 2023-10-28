using HRConnect.Server.Repository;
using HRConnect.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRConnect.Server.Controllers
{

    [ApiController]
    [Route("api/hardskill")]
    public class HardSkillController : ControllerBase
    {
        private IHardSkillRepository _hardskillRepository;
        public HardSkillController(IHardSkillRepository hardskillRepository)
        {
            _hardskillRepository = hardskillRepository;
        }

        [HttpGet("Lista")]
        public ActionResult<IEnumerable<HardSkill>> GetAllHardSkill()
        {
            return _hardskillRepository.GetAllHardSkill().ToList();
        }
        [HttpDelete("{id}")]
        public void DeleteHardSkill(int id)
        {
            _hardskillRepository.DeleteHardSkill(id);
        }

        [HttpPost("Add")]
        public ActionResult AddHardSkill([FromBody] HardSkill nuovoHardSkill)
        {
            if (nuovoHardSkill == null)
            {
                return BadRequest("I dati delle hardskill sono incomplete.");
            }
            _hardskillRepository.AddHardSkill(nuovoHardSkill);
            return Ok();
        }

        [HttpPut("Aggiorna")]
        public ActionResult<HardSkill> UpdateHardSkill(int id, HardSkill hardskill)
        {
            return _hardskillRepository.UpdateHardSkill(id, hardskill);
        }


    }
}
