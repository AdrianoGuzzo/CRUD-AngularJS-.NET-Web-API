using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentsCRUD.Model;

namespace TalentsCRUD.Repository.Interface
{
    public interface ITalentRepository
    {
        bool Add(Talent model);
        IQueryable<Talent> GetList();
        bool Delete(Guid Id);
        Talent Get(Guid Id);
        bool AddOrUpdate(Talent model);
    }
}
