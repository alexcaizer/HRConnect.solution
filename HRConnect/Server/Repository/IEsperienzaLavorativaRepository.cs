using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public interface IEsperienzaLavorativaRepository
    {
        public IEnumerable<EsperienzaLavorativa> GetAllEsperienzeLavorative();
        public EsperienzaLavorativa AddEsperienzaLavorativa(EsperienzaLavorativa nuovoEsperienzaLavorativa);
        public EsperienzaLavorativa UpdateEsperienzaLavorativa(int id, EsperienzaLavorativa esperienzalavorativa);
        public void DeleteEsperienzaLavorativa(int id);
    }
}
