using HRConnect.Server.AppDbContext;
using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public class CittaRepository : ICittaRepository
    {
        public Citta AddCitta(Citta nuovoCitta)
        {
            _context.Citta.Add(nuovoCitta);
            _context.SaveChanges();
            return nuovoCitta;
        }


        public void DeleteCitta(int id)
        {
            var nuovoCitta = _context.Citta.FirstOrDefault(d => d.Id == id);
            if (nuovoCitta != null)
            {
                _context.Citta.Remove(nuovoCitta);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Citta> GetAllCitta()
        {
            return _context.Citta.ToList();
        }

        public Citta UpdateCitta(int id, Citta citta)
        {
            var nuovoCitta = _context.Citta.FirstOrDefault(d => d.Id == id);
            if (nuovoCitta != null)
            {
                nuovoCitta.Sede = citta.Sede;
                nuovoCitta.Nome = citta.Nome;
                nuovoCitta.Candidati = citta.Candidati;

                _context.SaveChanges();

            }
            return _context.Citta.FirstOrDefault(d => d.Id == id);
        }

        private ApplicationDbContext _context;

        public CittaRepository(ApplicationDbContext context)
        {
            _context = context;

        }
    }
}
