using HRConnect.Server.AppDbContext;
using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public class CandidatoRepository : ICandidatoRepository
    {

        public Candidato AddCandidato(Candidato nuovoCandidato)
        {
            _context.Candidati.Add(nuovoCandidato);
            _context.SaveChanges();
            return nuovoCandidato;
        }


        public void DeleteCandidato(int id)
        {
            var nuovoCandidato = _context.Candidati.FirstOrDefault(d => d.Id == id);
            if (nuovoCandidato != null)
            {
                _context.Candidati.Remove(nuovoCandidato);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Candidato> GetAllCandidati()
        {
            return _context.Candidati.ToList();
        }

        public Candidato UpdateCandidato(int id, Candidato candidato)
        {
            var nuovoCandidato = _context.Candidati.FirstOrDefault(d => d.Id == id);
            if (nuovoCandidato != null)
            {
                nuovoCandidato.Nome = candidato.Nome;
                nuovoCandidato.Cognome = candidato.Cognome;
                nuovoCandidato.Email = candidato.Cognome;
                nuovoCandidato.Telefono = candidato.Cognome;
                nuovoCandidato.ComuneDiNascita = candidato.Cognome;
                nuovoCandidato.ProvinciaDiNascita = candidato.Cognome;
                nuovoCandidato.StatoDiNascita = candidato.StatoDiNascita;
                nuovoCandidato.Citta = candidato.Citta;
                nuovoCandidato.Documento = candidato.Documento;
                nuovoCandidato.SoftSkills = candidato.SoftSkills;
                nuovoCandidato.HardSkills = candidato.HardSkills;
                nuovoCandidato.Colloquio = candidato.Colloquio;
                nuovoCandidato.EsperienzeLavorative = candidato.EsperienzeLavorative;
                nuovoCandidato.TitoloDiStudio = candidato.TitoloDiStudio;
                nuovoCandidato.Contratto = candidato.Contratto;
                //da aggiungere tutto anche icollection softskill,hardskill,citta,documentoid..etc
                nuovoCandidato.StatoDiNascita = candidato.Cognome;
                _context.SaveChanges();

            }
            return _context.Candidati.FirstOrDefault(d => d.Id == id);
        }

        private ApplicationDbContext _context;

        public CandidatoRepository(ApplicationDbContext context)
        {
            _context = context;

        }

    }
}
