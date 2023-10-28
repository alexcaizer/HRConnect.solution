using HRConnect.Server.AppDbContext;
using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public class DocumentoRepository : IDocumentoRepository
    {
        public Documento AddDocumento(Documento nuovoDocumento)
        {
            _context.Documenti.Add(nuovoDocumento);
            _context.SaveChanges();
            return nuovoDocumento;
        }


        public void DeleteDocumento(int id)
        {
            var nuovoDocumento = _context.Documenti.FirstOrDefault(d => d.Id == id);
            if (nuovoDocumento != null)
            {
                _context.Documenti.Remove(nuovoDocumento);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Documento> GetAllDocumenti()
        {
            return _context.Documenti.ToList();
        }

        public Documento UpdateDocumento(int id, Documento documento)
        {
            var nuovoDocumento = _context.Documenti.FirstOrDefault(d => d.Id == id);
            if (nuovoDocumento != null)
            {
                nuovoDocumento.TipologiaDocumento = documento.TipologiaDocumento;
                nuovoDocumento.Candidato = documento.Candidato;
                

                _context.SaveChanges();

            }
            return _context.Documenti.FirstOrDefault(d => d.Id == id);
        }

        private ApplicationDbContext _context;

        public DocumentoRepository(ApplicationDbContext context)
        {
            _context = context;

        }
    }
}
