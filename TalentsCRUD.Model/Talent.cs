using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentsCRUD.Model
{
    public class Talent : ModelBase
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Skype { get; set; }
        public string Phone { get; set; }
        public string Linkedin { get; set; }
        public string Portfolio { get; set; }
        public string QuestionWillingness { get; set; }
        public string QuestionBestTime { get; set; }
        public int SalaryHour { get; set; }
        public string OtherTechnology { get; set; }
        public string LinkCRUD { get; set; }

        public virtual Bank Bank { get; set; }
        public virtual ICollection<Rate> Rates { get; set; }
    }
}
