using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentsCRUD.DBContext;
using TalentsCRUD.Model;
using TalentsCRUD.Repository.Interface;

namespace TalentsCRUD.Repository
{
    public class RateRepository : RepositoryBase<Rate>, IRateRepository
    {
        public RateRepository(DBContext.DBContext _context) : base(_context)
        {
        }

        public new bool Add(Rate model)
        {
            return base.Add(model);
        }

        public new bool AddOrUpdate(Rate model)
        {
            return base.AddOrUpdate(model);
        }
    }
}
