using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConnect.Shared.Models
{
    public class Dipendente
    {
        [Key]

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Cognome { get; set; }
        public int ContrattoId { get; set; }
        public int SedeId { get; set; }
        public int LivelloContrattualeId { get; set; }
        public int MansioneId { get; set; }
        public Contratto? Contratto { get; set; }
        public Sede? Sede { get; set; }
        public LivelloContrattuale? LivelliContrattuali { get; set; }
        public Mansione? Mansione { get; set; }
        public ICollection<SoftSkill>? SoftSkills { get; set; }
        public ICollection<HardSkill>? HardSkills { get; set; }
        public ICollection<Benefit>? Benefits { get; set; }
    }
}
