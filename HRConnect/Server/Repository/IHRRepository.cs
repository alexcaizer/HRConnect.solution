using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public interface IHRRepository
    {
        public IEnumerable<HR> GetAllHR();
        public HR AddHR(HR nuovoHR);
        public HR UpdateHR(int id, HR hr);
        public void DeleteHR(int id);
    }
}
