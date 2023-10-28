using HRConnect.Server.AppDbContext;
using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public class HRRepository : IHRRepository
    {
        public HR AddHR(HR nuovoHR)
        {
            _context.HRs.Add(nuovoHR);
            _context.SaveChanges();
            return nuovoHR;
        }


        public void DeleteHR(int id)
        {
            var nuovoHR = _context.HRs.FirstOrDefault(d => d.HRId == id);
            if (nuovoHR != null)
            {
                _context.HRs.Remove(nuovoHR);
                _context.SaveChanges();
            }
        }

        public IEnumerable<HR> GetAllHR()
        {
            return _context.HRs.ToList();
        }

        public HR UpdateHR(int id, HR hr)
        {
            var nuovoHR = _context.HRs.FirstOrDefault(d => d.HRId == id);
            if (nuovoHR != null)
            {
                nuovoHR.Nome = hr.Nome;
                nuovoHR.Cognome = hr.Cognome;
                nuovoHR.Sede = hr.Sede;
                nuovoHR.Colloqui = hr.Colloqui;


                _context.SaveChanges();

            }
            return _context.HRs.FirstOrDefault(d => d.HRId == id);
        }

        private ApplicationDbContext _context;

        public HRRepository(ApplicationDbContext context)
        {
            _context = context;

        }
    }
}
