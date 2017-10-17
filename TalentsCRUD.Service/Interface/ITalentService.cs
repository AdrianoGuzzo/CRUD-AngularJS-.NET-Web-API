using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentsCRUD.Model;

namespace TalentsCRUD.Service.Interface
{
    public interface ITalentService
    {
        bool AddTalent(Talent model);
        bool UpdateTalent(Talent model);
        object ListTalent();
        bool DeleteTalent(Guid Id);
        Talent EditTalent(Guid Id);
        object ViewTalent(Guid Id);
    }
}
