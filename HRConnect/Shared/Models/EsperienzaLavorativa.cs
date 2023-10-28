using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConnect.Shared.Models
{
    public class EsperienzaLavorativa
    {
        [Key]
        public int Id { get; set; }
        public DateTime? DataInizio { get; set; }
        public DateTime? DataFine { get; set; }
        public string? Azienda { get; set; }
        public string? Descrizione { get; set; }

        public Mansione? Mansione { get; set; }
        public Contratto? Contratto { get; set;}
        public Candidato? Candidato { get; set; }
    }
}
