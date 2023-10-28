using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public interface ILivelloContrattualeRepository
    {
        public IEnumerable<LivelloContrattuale> GetAllLivelliContrattuali();
        public LivelloContrattuale AddLivelloContrattuale(LivelloContrattuale nuovoLivelloContrattuale);
        public LivelloContrattuale UpdateLivelloContrattuale(int id, LivelloContrattuale livellocontrattuale);
        public void DeleteLivelloContrattuale(int id);
    }
}
