using HRConnect.Server.AppDbContext;
using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public class HardSkillRepository : IHardSkillRepository
    {
        public HardSkill AddHardSkill(HardSkill nuovoHardSkill)
        {
            _context.HardSkills.Add(nuovoHardSkill);
            _context.SaveChanges();
            return nuovoHardSkill;
        }


        public void DeleteHardSkill(int id)
        {
            var nuovoHardSkill = _context.HardSkills.FirstOrDefault(d => d.Id == id);
            if (nuovoHardSkill != null)
            {
                _context.HardSkills.Remove(nuovoHardSkill);
                _context.SaveChanges();
            }
        }

        public IEnumerable<HardSkill> GetAllHardSkill()
        {
            return _context.HardSkills.ToList();
        }

        public HardSkill UpdateHardSkill(int id, HardSkill hardskill)
        {
            var nuovoHardSkill = _context.HardSkills.FirstOrDefault(d => d.Id == id);
            if (nuovoHardSkill != null)
            {
                nuovoHardSkill.TipologiaSkill = hardskill.TipologiaSkill;
                nuovoHardSkill.Candidati = hardskill.Candidati;
                nuovoHardSkill.Dipendenti = hardskill.Dipendenti;
                nuovoHardSkill.LivelliContrattuali = hardskill.LivelliContrattuali;
                nuovoHardSkill.Contratti = hardskill.Contratti;

                _context.SaveChanges();

            }
            return _context.HardSkills.FirstOrDefault(d => d.Id == id);
        }

        private ApplicationDbContext _context;

        public HardSkillRepository(ApplicationDbContext context)
        {
            _context = context;

        }
    }
}
