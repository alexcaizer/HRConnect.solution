using HRConnect.Server.AppDbContext;
using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public class EsperienzaLavorativaRepository : IEsperienzaLavorativaRepository
    {
        public EsperienzaLavorativa AddEsperienzaLavorativa(EsperienzaLavorativa nuovoEsperienzaLavorativa)
        {
            _context.EsperienzeLavorative.Add(nuovoEsperienzaLavorativa);
            _context.SaveChanges();
            return nuovoEsperienzaLavorativa;
        }


        public void DeleteEsperienzaLavorativa(int id)
        {
            var nuovoEsperienzaLavorativa = _context.EsperienzeLavorative.FirstOrDefault(d => d.Id == id);
            if (nuovoEsperienzaLavorativa != null)
            {
                _context.EsperienzeLavorative.Remove(nuovoEsperienzaLavorativa);
                _context.SaveChanges();
            }
        }

        public IEnumerable<EsperienzaLavorativa> GetAllEsperienzeLavorative()
        {
            return _context.EsperienzeLavorative.ToList();
        }

        public EsperienzaLavorativa UpdateEsperienzaLavorativa(int id, EsperienzaLavorativa esperienzalavorativa)
        {
            var nuovoEsperienzaLavorativa = _context.EsperienzeLavorative.FirstOrDefault(d => d.Id == id);
            if (nuovoEsperienzaLavorativa != null)
            {
                nuovoEsperienzaLavorativa.DataInizio = esperienzalavorativa.DataInizio;
                nuovoEsperienzaLavorativa.DataFine = esperienzalavorativa.DataFine;
                nuovoEsperienzaLavorativa.Azienda = esperienzalavorativa.Azienda;
                nuovoEsperienzaLavorativa.Descrizione = esperienzalavorativa.Descrizione;
                nuovoEsperienzaLavorativa.Mansione = esperienzalavorativa.Mansione;
                nuovoEsperienzaLavorativa.Contratto = esperienzalavorativa.Contratto;
                nuovoEsperienzaLavorativa.Candidato = esperienzalavorativa.Candidato;

                _context.SaveChanges();

            }
            return _context.EsperienzeLavorative.FirstOrDefault(d => d.Id == id);

        }
        private ApplicationDbContext _context;

        public EsperienzaLavorativaRepository(ApplicationDbContext context)
        {
            _context = context;

        }
    }
}
