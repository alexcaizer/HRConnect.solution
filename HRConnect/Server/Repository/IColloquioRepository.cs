using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public interface IColloquioRepository
    {
        public IEnumerable<Colloquio> GetAllColloqui();
        public Colloquio AddColloquio(Colloquio nuovoColloquio);
        public Colloquio UpdateColloquio(int id, Colloquio colloquio);
        public void DeleteColloquio(int id);
    }
}
