using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public interface ICittaRepository
    {
            public IEnumerable<Citta> GetAllCitta();
            public Citta AddCitta(Citta nuovoCitta);
            public Citta UpdateCitta(int id, Citta citta);
            public void DeleteCitta(int id);
        
    }
}
