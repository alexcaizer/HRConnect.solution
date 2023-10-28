using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConnect.Shared.Models
{
    public class Colloquio
    {
        [Key]

        public int Id { get; set; }
        public DateTime? DataColloquio { get; set; }
        public string? Valutazione { get; set; }
        public string? Note { get; set; }
        public int HRId { get; set; }
        public int SedeId { get; set; }
        public Candidato? Candidato { get; set; }
        public HR? HR { get; set; }
        public Sede? Sede { get; set; }
    }
}
