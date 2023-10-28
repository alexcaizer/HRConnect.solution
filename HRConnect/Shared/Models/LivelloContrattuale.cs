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
        public bool Attivo { get; set; }
        public Dipendente? Dipendente { get; set; }
        public ICollection<Contratto>? Contratti { get; set; }
        public HardSkill? HardSkill { get; set; }
        public SoftSkill? SoftSkill { get; set; }


    }
}
