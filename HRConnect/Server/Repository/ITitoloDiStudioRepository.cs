using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public interface ITitoloDiStudioRepository
    {
        public IEnumerable<TitoloDiStudio> GetAllTitoliDiStudio();
        public TitoloDiStudio AddTitoloDiStudio(TitoloDiStudio nuovoTitoloDiStudio);
        public TitoloDiStudio UpdateTitoloDiStudio(int id, TitoloDiStudio titolodistudio);
        public void DeleteTitoloDiStudio(int id);
    }
}
