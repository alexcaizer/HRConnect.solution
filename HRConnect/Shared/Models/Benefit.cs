using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConnect.Shared.Models
{
    public class Benefit
    {
        [Key]

        public int Id { get; set; }
        public string? Descrizione { get; set; }
        public bool Attivo { get; set; }

        public ICollection<Dipendente>? Dipendenti { get; set; }
        // Rapporto N a N.
        
    }
}
