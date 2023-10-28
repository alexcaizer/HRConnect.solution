using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConnect.Shared.Models
{
    public class Citta
    {
        [Key]

        public int Id { get; set; }
        public string? Nome { get; set; }
        public int SedeId { get; set; }
        public Sede? Sede { get; set; }
        public ICollection<Candidato>? Candidati { get; set; }
    }
}
