using HRConnect.Server.AppDbContext;
using HRConnect.Shared.Models;
using Microsoft.IdentityModel.Tokens;

namespace HRConnect.Server.Repository
{
    public class BenefitRepository : IBenefitRepository
    {
            public Benefit AddBenefit(Benefit nuovoBenefit)
            {
                _context.Benefits.Add(nuovoBenefit);
                _context.SaveChanges();
                return nuovoBenefit;
            }


            public void DeleteBenefit(int id)
            {
                var nuovoBenefit = _context.Benefits.FirstOrDefault(d => d.Id == id);
                if (nuovoBenefit != null)
                {
                    _context.Benefits.Remove(nuovoBenefit);
                    _context.SaveChanges();
                }
            }

            public IEnumerable<Benefit> GetAllBenefit()
            {
                return _context.Benefits.ToList();
            }

            public Benefit UpdateBenefit(int id, Benefit benefit)
            {
                var nuovoBenefit = _context.Benefits.FirstOrDefault(d => d.Id == id);
                if (nuovoBenefit != null)
                {
                    nuovoBenefit.Dipendenti = benefit.Dipendenti;
                    nuovoBenefit.Descrizione = benefit.Descrizione;
                    _context.SaveChanges();

                }
                return _context.Benefits.FirstOrDefault(d => d.Id == id);
            }

            private ApplicationDbContext _context;

            public BenefitRepository(ApplicationDbContext context)
            {
                _context = context;

            }

        }
    }

