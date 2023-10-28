using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public interface ISedeRepository
    {
        public IEnumerable<Sede> GetAllSedi();
        public Sede AddSede(Sede nuovoSede);
        public Sede UpdateSede(int id, Sede sede);
        public void DeleteSede(int id);
    }
}
