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
    public class BankRepository : RepositoryBase<Bank>, IBankRepository
    {
        public BankRepository(DBContext.DBContext _context) : base(_context)
        {
        }

        public new bool Add(Bank model)
        {            
            return base.Add(model);
        }

        public new bool AddOrUpdate(Bank model)
        {
            return base.AddOrUpdate(model);
        }
    }
}
