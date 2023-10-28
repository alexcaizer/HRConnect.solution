﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConnect.Shared.Models
{
   public class SoftSkill
    {
        [Key]
        public int Id { get; set; }
        public string? TipologiaSkill { get; set; }
        public ICollection<Candidato>? Candidati { get; set; }
        public ICollection<Dipendente>? Dipendenti { get; set; }
        public ICollection<LivelloContrattuale>? LivelloContrattuale{ get; set; }
        public bool Attivo { get; set; }
    }
}
