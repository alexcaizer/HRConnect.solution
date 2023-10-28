using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public interface ISoftSkillRepository
    {
        public IEnumerable<SoftSkill> GetAllSoftSkill();
        public SoftSkill AddSoftSkill(SoftSkill nuovoSoftSkill);
        public SoftSkill UpdateSoftSkill(int id, SoftSkill softskill);
        public void DeleteSoftSkill(int id);
    }
}
