using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public interface IContrattoRepository
    {
        public IEnumerable<Contratto> GetAllContratti();
        public Contratto AddContratto(Contratto nuovoContratto);
        public Contratto UpdateContratto(int id, Contratto contratto);
        public void DeleteContratto(int id);
    }
}
