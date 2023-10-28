using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public interface IBenefitRepository
    {

        public IEnumerable<Benefit> GetAllBenefit();
        public Benefit AddBenefit(Benefit nuovoBenefit);
        public Benefit UpdateBenefit(int id, Benefit benefit);
        public void DeleteBenefit(int id);
    }
}
