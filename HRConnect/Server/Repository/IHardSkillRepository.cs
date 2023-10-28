using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public interface IHardSkillRepository
    {
        public IEnumerable<HardSkill> GetAllHardSkill();
        public HardSkill AddHardSkill(HardSkill nuovoHardSkill);
        public HardSkill UpdateHardSkill(int id, HardSkill hardskill);
        public void DeleteHardSkill(int id);
    }
}
