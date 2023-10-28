using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConnect.Shared.Models
{
    public class Contratto
    {
        [Key]

        public int Id { get; set; }
        public string? TipoContratto { get; set; }
         
        //Rapporto N Contratti - 1 Livello
        public bool Attivo { get; set; }
        public LivelloContrattuale? LivelloContrattuale { get; set; }
        public ICollection<Candidato>? Candidato { get; set; }
    }
}
