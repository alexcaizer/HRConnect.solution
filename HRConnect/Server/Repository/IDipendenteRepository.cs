using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public interface IDipendenteRepository
    {
        public IEnumerable<Dipendente> GetAllDipendenti();
        public Dipendente AddDipendente(Dipendente nuovoDipendente);
        public Dipendente UpdateDipendente(int id, Dipendente dipendente);
        public void DeleteDipendente(int id);
    }
}
