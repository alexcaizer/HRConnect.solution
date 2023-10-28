using HRConnect.Server.AppDbContext;
using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public class SoftSkillRepository : ISoftSkillRepository
    {
        public SoftSkill AddSoftSkill(SoftSkill nuovoSoftSkill)
        {
            _context.SoftSkills.Add(nuovoSoftSkill);
            _context.SaveChanges();
            return nuovoSoftSkill;
        }


        public void DeleteSoftSkill(int id)
        {
            var nuovoSoftSkill = _context.SoftSkills.FirstOrDefault(d => d.Id == id);
            if (nuovoSoftSkill != null)
            {
                _context.SoftSkills.Remove(nuovoSoftSkill);
                _context.SaveChanges();
            }
        }

        public IEnumerable<SoftSkill> GetAllSoftSkill()
        {
            return _context.SoftSkills.ToList();
        }

        public SoftSkill UpdateSoftSkill(int id, SoftSkill softskill)
        {
            var nuovoSoftSkill = _context.SoftSkills.FirstOrDefault(d => d.Id == id);
            if (nuovoSoftSkill != null)
            {
                nuovoSoftSkill.TipologiaSkill = softskill.TipologiaSkill;
                nuovoSoftSkill.Candidati = softskill.Candidati;
                nuovoSoftSkill.Dipendenti = softskill.Dipendenti;
                nuovoSoftSkill.LivelloContrattuale = softskill.LivelloContrattuale;
                nuovoSoftSkill.Contratti = softskill.Contratti;

                _context.SaveChanges();

            }
            return _context.SoftSkills.FirstOrDefault(d => d.Id == id);
        }

        private ApplicationDbContext _context;

        public SoftSkillRepository(ApplicationDbContext context)
        {
            _context = context;

        }
    }
}
