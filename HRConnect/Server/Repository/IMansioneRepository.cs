using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public interface IMansioneRepository
    {
        public IEnumerable<Mansione> GetAllMansioni();
        public Mansione AddMansione(Mansione nuovoMansione);
        public Mansione UpdateMansione(int id, Mansione mansione);
        public void DeleteMansione(int id);
    }
}
