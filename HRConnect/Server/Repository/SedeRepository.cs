using HRConnect.Server.AppDbContext;
using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public class SedeRepository : ISedeRepository
    {
        public Sede AddSede(Sede nuovoSede)
        {
            _context.Sedi.Add(nuovoSede);
            _context.SaveChanges();
            return nuovoSede;
        }


        public void DeleteSede(int id)
        {
            var nuovoSede = _context.Sedi.FirstOrDefault(d => d.SedeId == id);
            if (nuovoSede != null)
            {
                _context.Sedi.Remove(nuovoSede);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Sede> GetAllSedi()
        {
            return _context.Sedi.ToList();
        }

        public Sede UpdateSede(int id, Sede sede)
        {
            var nuovoSede = _context.Sedi.FirstOrDefault(d => d.SedeId == id);
            if (nuovoSede != null)
            {
                nuovoSede.Descrizione = sede.Descrizione;
                nuovoSede.Indirizzo = sede.Indirizzo;
                nuovoSede.Recapito = sede.Recapito;
                nuovoSede.HR = sede.HR;
                nuovoSede.Dipendenti = sede.Dipendenti;
                nuovoSede.Colloqui = sede.Colloqui;
                nuovoSede.Cittas = sede.Cittas;



                _context.SaveChanges();

            }
            return _context.Sedi.FirstOrDefault(d => d.SedeId == id);
        }

        private ApplicationDbContext _context;

        public SedeRepository(ApplicationDbContext context)
        {
            _context = context;

        }
    }
}
