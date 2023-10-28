using HRConnect.Server.Repository;
using HRConnect.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRConnect.Server.Controllers
{

    [ApiController]
    [Route("api/softskill")]
    public class SoftSkillController : ControllerBase
    {
        private ISoftSkillRepository _softskillRepository;
        public SoftSkillController(ISoftSkillRepository softskillRepository)
        {
            _softskillRepository = softskillRepository;
        }

        [HttpGet("Lista")]
        public ActionResult<IEnumerable<SoftSkill>> GetAllSoftSkill()
        {
            return _softskillRepository.GetAllSoftSkill().ToList();
        }
        [HttpDelete("{id}")]
        public void DeleteSoftSkill(int id)
        {
            _softskillRepository.DeleteSoftSkill(id);
        }

        [HttpPost("Add")]
        public ActionResult AddSoftSkill([FromBody] SoftSkill nuovoSoftSkill)
        {
            if (nuovoSoftSkill == null)
            {
                return BadRequest("I dati delle softskills sono incomplete.");
            }
            _softskillRepository.AddSoftSkill(nuovoSoftSkill);
            return Ok();
        }

        [HttpPut("Aggiorna")]
        public ActionResult<SoftSkill> UpdateCandidato(int id, SoftSkill softskill)
        {
            return _softskillRepository.UpdateSoftSkill(id, softskill);
        }


    }
}
