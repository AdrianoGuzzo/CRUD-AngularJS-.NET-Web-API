using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentsCRUD.Model
{
    public class TypeTechnology
    {
        [Key]
        public EnumTypeTechnology Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Rate> Rates { get; set; }
    }
}
