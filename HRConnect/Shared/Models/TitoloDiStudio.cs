using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConnect.Shared.Models
{
    public class TitoloDiStudio
    {
        [Key]
        public int Id { get; set; }
        public string? TipologiaTitolo { get; set; }
        public ICollection<Candidato>? Candidati { get; set; }
        public bool Attivo { get; set; }

    }
}
