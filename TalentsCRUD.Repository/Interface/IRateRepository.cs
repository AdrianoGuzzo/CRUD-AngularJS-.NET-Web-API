using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentsCRUD.Model;

namespace TalentsCRUD.Repository.Interface
{
    public interface IRateRepository
    {
        bool Add(Rate model);
        bool AddOrUpdate(Rate model);
    }
}
