using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentsCRUD.Model;
using TalentsCRUD.Repository;
using TalentsCRUD.Repository.Interface;
using TalentsCRUD.Service.Interface;

namespace TalentsCRUD.Service
{
    public class TalentService : ServiceBase, ITalentService
    {
        ITalentRepository talentRepository;
        IBankRepository bankRepository;
        IRateRepository rateRepository;

        public TalentService(InjectRepository injectRepository) : base(injectRepository)
        {
            talentRepository = injectRepository.GetTalentRepository();
            bankRepository = injectRepository.GetBankRepository();
            rateRepository = injectRepository.GetRateRepository();
        }

        public bool AddTalent(Talent model)
        {
            foreach (Rate rate in model.Rates.Where(x => x.Id == Guid.Empty))
            {
                rate.Id = Guid.NewGuid();
                rate.DateCreate = DateTime.Now;
                rate.Status = EnumStatus.Active;
            }
            if (model.Bank != null)
            {
                model.Bank.Status = EnumStatus.Active;
                model.Bank.DateCreate = DateTime.Now;
            }

            return talentRepository.Add(model);
        }
        public bool UpdateTalent(Talent model)
        {

            foreach (Rate rate in model.Rates)
            {
                if (rate.Id == Guid.Empty)
                {
                    rate.IdTalent = model.Id;
                    rateRepository.Add(rate);
                }
                else
                    rateRepository.AddOrUpdate(rate);
            }

            return talentRepository.AddOrUpdate(model);
        }

        public object ListTalent()
        {
            return talentRepository.GetList().Select(x => new
            {
                Id = x.Id,
                Name = x.Name,
                State = x.State,
                City = x.City,
            });
        }

        public bool DeleteTalent(Guid Id)
        {
            return talentRepository.Delete(Id);
        }
        public Talent EditTalent(Guid Id)
        {
            return talentRepository.Get(Id);
        }
    }
}
