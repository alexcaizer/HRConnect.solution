using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConnect.Shared.Models
{
    public class HR
    {
        [Key]
        public int HRId { get; set; }
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public Sede? Sede { get; set; }
        public ICollection<Colloquio>? Colloqui { get; set; }
        
    }
}
