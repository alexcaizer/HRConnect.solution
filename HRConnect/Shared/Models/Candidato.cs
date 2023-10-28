using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConnect.Shared.Models
{
    public class Candidato
    {
        [Key]

        public int Id { get; set; }
        
        
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public string? ComuneDiNascita { get; set; }
        public string? ProvinciaDiNascita { get; set; }
        public string? StatoDiNascita { get; set; }

        public Citta? Citta { get; set; } //citta residenza
        //---------------------------------------------
        public int DocumentoID { get; set; }
        public Documento? Documento { get; set; }
        public ICollection<SoftSkill>? SoftSkills { get; set; }
        public ICollection<HardSkill>? HardSkills { get; set; }
        public ICollection<Colloquio>? Colloquio { get; set; }
        public ICollection<EsperienzaLavorativa>? EsperienzeLavorative { get; set; } 
        


    }
}
