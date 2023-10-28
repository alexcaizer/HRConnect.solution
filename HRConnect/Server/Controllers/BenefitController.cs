using HRConnect.Server.Repository;
using HRConnect.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design.Serialization;

namespace HRConnect.Server.Controllers
{
    [ApiController]
    [Route("api/benefit")]
    public class BenefitController : ControllerBase
    {
        
        private IBenefitRepository _benefitRepository;
        public BenefitController(IBenefitRepository benefitRepository)
        {
            _benefitRepository = benefitRepository;
        }

        [HttpGet("Lista")]
        public ActionResult<IEnumerable<Benefit>> GetAllBenefit()
        {
            return _benefitRepository.GetAllBenefit().ToList();
        }
        [HttpDelete("{id}")]
        public void DeleteBenefit(int id)
        {
            _benefitRepository.DeleteBenefit(id);
        }

        [HttpPost("Add")]
        public ActionResult AddBenefit([FromBody] Benefit nuovoBenefit)
        {
            if (nuovoBenefit == null)
            {
                return BadRequest("I dati del Benefits sono incompleti.");
            }
            _benefitRepository.AddBenefit(nuovoBenefit);
            return Ok();
        }

        [HttpPut("Aggiorna")]
        public ActionResult<Benefit> UpdateBenefit(int id, Benefit benefit)
        {
            return _benefitRepository.UpdateBenefit(id, benefit);
        }


    }
}
