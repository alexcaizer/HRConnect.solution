using HRConnect.Shared.Models;

namespace HRConnect.Server.Repository
{
    public interface ICandidatoRepository
    {

            public IEnumerable<Candidato> GetAllCandidati();
            public Candidato AddCandidato(Candidato nuovoCandidato);
            public Candidato UpdateCandidato(int id, Candidato candidato);
            public void DeleteCandidato(int id);
        
    }
}
