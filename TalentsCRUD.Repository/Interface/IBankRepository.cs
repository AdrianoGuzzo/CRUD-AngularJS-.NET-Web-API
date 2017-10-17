using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentsCRUD.Model;

namespace TalentsCRUD.Repository.Interface
{
    public interface IBankRepository
    {
        bool Add(Bank model);
        bool AddOrUpdate(Bank model);
    }
}
