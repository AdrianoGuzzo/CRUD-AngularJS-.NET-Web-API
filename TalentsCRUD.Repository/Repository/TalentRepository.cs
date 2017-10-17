using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TalentsCRUD.DBContext;
using TalentsCRUD.Model;
using TalentsCRUD.Repository.Interface;

namespace TalentsCRUD.Repository
{
    public class TalentRepository : RepositoryBase<Talent>, ITalentRepository
    {
        public TalentRepository(DBContext.DBContext _context) : base(_context)
        {
        }

        public new bool Add(Talent model)
        {
            base.Add(model);
            return base.SaveChange();
        }
        public new bool AddOrUpdate(Talent model)
        {
            model.DateAlter = DateTime.Now;
            base.AddOrUpdate(model);
            return base.SaveChange();
        }
        public IQueryable<Talent> GetList()
        {
            return base.Read(x => x.Status == EnumStatus.Active, true);
        }
        public Talent Get(Guid Id, params Expression<Func<Talent, object>>[] includes)
        {
            return base.Find(Id, includes);
        }
        public bool Delete(Guid Id)
        {
            return base.DeleteById(Id);
        }

    }
}
