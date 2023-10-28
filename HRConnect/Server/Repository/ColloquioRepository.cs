using HRConnect.Server.AppDbContext;
using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public class ColloquioRepository : IColloquioRepository
    {
        public Colloquio AddColloquio(Colloquio nuovoColloquio)
        {
            _context.Colloqui.Add(nuovoColloquio);
            _context.SaveChanges();
            return nuovoColloquio;
        }


        public void DeleteColloquio(int id)
        {
            var nuovoColloquio = _context.Colloqui.FirstOrDefault(d => d.Id == id);
            if (nuovoColloquio != null)
            {
                _context.Colloqui.Remove(nuovoColloquio);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Colloquio> GetAllColloqui()
        {
            return _context.Colloqui.ToList();
        }

        public Colloquio UpdateColloquio(int id, Colloquio colloquio)
        {
            var nuovoColloquio = _context.Colloqui.FirstOrDefault(d => d.Id == id);
            if (nuovoColloquio != null)
            {
                nuovoColloquio.DataColloquio = colloquio.DataColloquio;
                nuovoColloquio.Candidato = colloquio.Candidato;
                nuovoColloquio.HR = colloquio.HR;
                nuovoColloquio.Sede = colloquio.Sede;
                nuovoColloquio.Valutazione = colloquio.Valutazione;
                nuovoColloquio.Note = colloquio.Note;
                nuovoColloquio.Sede = colloquio.Sede;
                _context.SaveChanges();

            }
            return _context.Colloqui.FirstOrDefault(d => d.Id == id);
        }

        private ApplicationDbContext _context;

        public ColloquioRepository(ApplicationDbContext context)
        {
            _context = context;

        }
    }
}
