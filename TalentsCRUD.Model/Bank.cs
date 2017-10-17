using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentsCRUD.Model
{
    public class Bank : ModelBase
    {
        [Key]
        [ForeignKey("Talent")]
        override public Guid Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string NameBank { get; set; }
        public string Agency { get; set; }
        public string Number { get; set; }
        public EnumTypeAccount? Type { get; set; }

        public virtual Talent Talent { get; set; }
    }
}
