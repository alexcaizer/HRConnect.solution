using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public interface IDocumentoRepository
    {
        public IEnumerable<Documento> GetAllDocumenti();
        public Documento AddDocumento(Documento nuovoDocumento);
        public Documento UpdateDocumento(int id, Documento documento);
        public void DeleteDocumento(int id);
    }
}
