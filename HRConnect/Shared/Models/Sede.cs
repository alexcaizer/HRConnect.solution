using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConnect.Shared.Models
{
    public class Sede
    {
        [Key]
        public int SedeId { get; set; }
        [Required]public string? Descrizione { get; set; }
        [Required]public string? Indirizzo { get; set; }
        [Required]public string? Recapito { get; set; }
        public int HRId { get; set; }
        public HR? HR { get; set; }
        public ICollection<Dipendente>? Dipendenti { get; set; }
        public ICollection<Colloquio>? Colloqui { get; set; }
        



}
}
