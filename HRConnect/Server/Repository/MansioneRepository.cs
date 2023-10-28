using HRConnect.Server.AppDbContext;
using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public class MansioneRepository : IMansioneRepository
    {
        public Mansione AddMansione(Mansione nuovoMansione)
        {
            _context.Mansioni.Add(nuovoMansione);
            _context.SaveChanges();
            return nuovoMansione;
        }


        public void DeleteMansione(int id)
        {
            var nuovoMansione = _context.Mansioni.FirstOrDefault(d => d.Id == id);
            if (nuovoMansione != null)
            {
                _context.Mansioni.Remove(nuovoMansione);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Mansione> GetAllMansioni()
        {
            return _context.Mansioni.ToList();
        }

        public Mansione UpdateMansione(int id, Mansione mansione)
        {
            var nuovoMansione = _context.Mansioni.FirstOrDefault(d => d.Id == id);
            if (nuovoMansione != null)
            {
                nuovoMansione.Descrizione = mansione.Descrizione;
                nuovoMansione.Dipendenti = mansione.Dipendenti;


                _context.SaveChanges();

            }
            return _context.Mansioni.FirstOrDefault(d => d.Id == id);
        }

        private ApplicationDbContext _context;

        public MansioneRepository(ApplicationDbContext context)
        {
            _context = context;

        }
    }
}
