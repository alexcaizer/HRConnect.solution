using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConnect.Shared.Models
{
    public class Documento
    {
        [Key]

        public int Id { get; set; }
        public string? TipologiaDocumento { get; set; }
        public bool Attivo { get; set; }
        public Candidato? Candidato { get; set; }


    }
}

