using HRConnect.Server.AppDbContext;
using HRConnect.Shared.Models;
using Microsoft.IdentityModel.Tokens;
using System.Linq;

namespace HRConnect.Server.Repository
{
    public class DipendenteRepository : IDipendenteRepository
    {
        public Dipendente AddDipendente(Dipendente nuovoDipendente)
        {
            _context.Dipendenti.Add(nuovoDipendente);
            _context.SaveChanges();
            return nuovoDipendente;
        }


        public void DeleteDipendente(int id)
        {
            var nuovoDipendte = _context.Dipendenti.FirstOrDefault(d => d.Id == id);
            if (nuovoDipendte != null)
            {
                _context.Dipendenti.Remove(nuovoDipendte);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Dipendente> GetAllDipendenti()
        {
            return _context.Dipendenti.ToList();
        }

        public Dipendente UpdateDipendente(int id, Dipendente dipendente)
        {
            var nuovoDipendente = _context.Dipendenti.FirstOrDefault(d => d.Id == id);
            if (nuovoDipendente != null)
            {
                nuovoDipendente.Name = dipendente.Name;
                nuovoDipendente.Cognome = dipendente.Cognome;
                nuovoDipendente.Contratto = dipendente.Contratto;
                nuovoDipendente.Sede = dipendente.Sede;
                nuovoDipendente.LivelliContrattuali = dipendente.LivelliContrattuali;
                nuovoDipendente.Mansione = dipendente.Mansione;
                nuovoDipendente.SoftSkills = dipendente.SoftSkills;
                nuovoDipendente.HardSkills = dipendente.HardSkills;
                nuovoDipendente.Benefits = dipendente.Benefits;

                _context.SaveChanges();
                
            }
            return _context.Dipendenti.FirstOrDefault(d => d.Id == id);
        }

        private ApplicationDbContext _context;

        public DipendenteRepository(ApplicationDbContext context)
        {
            _context = context;
            
        }

    }
}
