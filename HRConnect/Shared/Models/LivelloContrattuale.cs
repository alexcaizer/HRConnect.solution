using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConnect.Shared.Models
{
    public class LivelloContrattuale
    {
        [Key]
        public int Id { get; set; }
        public int Livello { get; set; }
        public ICollection<HardSkill>? HardSkills { get; set; }
        public ICollection<SoftSkill>? SoftSkills { get; set; }
        public ICollection<Contratto>? Contratti { get; set; }
        //rapporto N Livelli - 1 Contratto
        public bool Attivo { get; set; }

    }
}
