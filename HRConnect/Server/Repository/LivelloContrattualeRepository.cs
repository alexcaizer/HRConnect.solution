using HRConnect.Server.AppDbContext;
using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public class LivelloContrattualeRepository : ILivelloContrattualeRepository
    {
        public LivelloContrattuale AddLivelloContrattuale(LivelloContrattuale nuovoLivelloContrattuale)
        {
            _context.LivelliContrattuali.Add(nuovoLivelloContrattuale);
            _context.SaveChanges();
            return nuovoLivelloContrattuale;
        }


        public void DeleteLivelloContrattuale(int id)
        {
            var nuovoLivelloContrattuale = _context.LivelliContrattuali.FirstOrDefault(d => d.Id == id);
            if (nuovoLivelloContrattuale != null)
            {
                _context.LivelliContrattuali.Remove(nuovoLivelloContrattuale);
                _context.SaveChanges();
            }
        }

        public IEnumerable<LivelloContrattuale> GetAllLivelliContrattuali()
        {
            return _context.LivelliContrattuali.ToList();
        }

        public LivelloContrattuale UpdateLivelloContrattuale(int id, LivelloContrattuale livellocontrattuale)
        {
            var nuovoLivelloContrattuale = _context.LivelliContrattuali.FirstOrDefault(d => d.Id == id);
            if (nuovoLivelloContrattuale != null)
            {
                nuovoLivelloContrattuale.Livello = livellocontrattuale.Livello;
                nuovoLivelloContrattuale.HardSkill = livellocontrattuale.HardSkill;
                nuovoLivelloContrattuale.SoftSkill = livellocontrattuale.SoftSkill;
                nuovoLivelloContrattuale.Contratti = livellocontrattuale.Contratti;
                nuovoLivelloContrattuale.Dipendente = livellocontrattuale.Dipendente;


                _context.SaveChanges();

            }
            return _context.LivelliContrattuali.FirstOrDefault(d => d.Id == id);
        }

        private ApplicationDbContext _context;

        public LivelloContrattualeRepository(ApplicationDbContext context)
        {
            _context = context;

        }
    }
}
