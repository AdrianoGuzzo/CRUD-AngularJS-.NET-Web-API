using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentsCRUD.Repository;
using TalentsCRUD.Repository.Interface;

namespace TalentsCRUD
{
    public class InjectRepository
    {
        private DBContext.DBContext context = new DBContext.DBContext();

        private ITalentRepository talentRepository;
        public ITalentRepository GetTalentRepository()
        {
            if (talentRepository == null)
                talentRepository = new TalentRepository(context);
            return talentRepository;
        }

        private IRateRepository rateRepository;
        public IRateRepository GetRateRepository()
        {
            if (rateRepository == null)
                rateRepository = new RateRepository(context);
            return rateRepository;
        }

        private IBankRepository bankRepository;
        public IBankRepository GetBankRepository()
        {
            if (bankRepository == null)
                bankRepository = new BankRepository(context);
            return bankRepository;
        }
    }
}
