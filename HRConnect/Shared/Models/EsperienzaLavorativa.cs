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
        public string? Mansione { get; set; }
        public string? Contratto { get; set; }
        public int CandidatoId { get; set; }
        public Candidato? Candidato { get; set; }
    }
}
