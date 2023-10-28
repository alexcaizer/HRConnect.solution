using HRConnect.Server.AppDbContext;
using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public class ContrattoRepository : IContrattoRepository
    {
        public Contratto AddContratto(Contratto nuovoContratto)
        {
            _context.Contratti.Add(nuovoContratto);
            _context.SaveChanges();
            return nuovoContratto;
        }


        public void DeleteContratto(int id)
        {
            var nuovoContratto = _context.Contratti.FirstOrDefault(d => d.Id == id);
            if (nuovoContratto != null)
            {
                _context.Contratti.Remove(nuovoContratto);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Contratto> GetAllContratti()
        {
            return _context.Contratti.ToList();
        }

        public Contratto UpdateContratto(int id, Contratto contratto)
        {
            var nuovoContratto = _context.Contratti.FirstOrDefault(d => d.Id == id);
            if (nuovoContratto != null)
            {
                nuovoContratto.TipoContratto = contratto.TipoContratto;
                nuovoContratto.LivelloContrattuale = contratto.LivelloContrattuale;
                nuovoContratto.Candidato = contratto.Candidato;
                nuovoContratto.Dipendentes = contratto.Dipendentes;
                nuovoContratto.HardSkills = contratto.HardSkills;
                nuovoContratto.SoftSkills = contratto.SoftSkills;
                _context.SaveChanges();

            }
            return _context.Contratti.FirstOrDefault(d => d.Id == id);
        }

        private ApplicationDbContext _context;

        public ContrattoRepository(ApplicationDbContext context)
        {
            _context = context;

        }
    }
}
