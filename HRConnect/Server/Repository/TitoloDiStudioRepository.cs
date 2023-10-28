using HRConnect.Server.AppDbContext;
using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public class TitoloDiStudioRepository : ITitoloDiStudioRepository
    {
        public TitoloDiStudio AddTitoloDiStudio(TitoloDiStudio nuovoTDS)
        {
            _context.TitoliDiStudio.Add(nuovoTDS);
            _context.SaveChanges();
            return nuovoTDS;
        }


        public void DeleteTitoloDiStudio(int id) 
        { 
            var nuovoTDS = _context.TitoliDiStudio.FirstOrDefault(d => d.Id == id);
            if (nuovoTDS != null)
            {
                _context.TitoliDiStudio.Remove(nuovoTDS);
                _context.SaveChanges();
            }
        }

        public IEnumerable<TitoloDiStudio> GetAllTitoliDiStudio()
        {
            return _context.TitoliDiStudio.ToList();
        }

        public TitoloDiStudio UpdateTitoloDiStudio(int id, TitoloDiStudio tds)
        {
            var nuovoTDS = _context.TitoliDiStudio.FirstOrDefault(d => d.Id == id);
            if (nuovoTDS != null)
            {
                nuovoTDS.TipologiaTitolo = tds.TipologiaTitolo;
                nuovoTDS.Candidati = tds.Candidati;


                _context.SaveChanges();

            }
            return _context.TitoliDiStudio.FirstOrDefault(d => d.Id == id);
        }

        private ApplicationDbContext _context;

        public TitoloDiStudioRepository(ApplicationDbContext context)
        {
            _context = context;

        }
    }
}
