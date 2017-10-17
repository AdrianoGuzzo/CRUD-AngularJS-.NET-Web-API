using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentsCRUD.Model
{
    public class Rate : ModelBase
    {
        [ForeignKey("TypeTechnology")]
        public EnumTypeTechnology idTypeTechnology { get; set; }
        public int _Rate { get; set; }

        public Guid IdTalent { get; set; }

        [ForeignKey("IdTalent")]
        public virtual Talent Talent { get; set; }

        public virtual TypeTechnology TypeTechnology { get; set; }
    }
}
