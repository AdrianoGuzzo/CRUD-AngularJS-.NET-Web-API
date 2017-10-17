using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TalentsCRUD.Model;

namespace TalentsCRUD.WebAPI.ModelView
{
    public class TalentModelView : BaseModelView
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Skype { get; set; }
        public string Phone { get; set; }
        public string Linkedin { get; set; }
        public string Portfolio { get; set; }
        public int[] QuestionWillingness { get; set; }
        public int[] QuestionBestTime { get; set; }
        public int SalaryHour { get; set; }
        public string OtherTechnology { get; set; }
        public string LinkCRUD { get; set; }

        public BankModelView Bank { get; set; }
        public List<RateModelView> Rates { get; set; }

        public TalentModelView()
        {

        }

        //mapeamento feito na mão, poderia ter usado o AutoMapper
        public TalentModelView(Talent model)
        {
            this.Id = model.Id;
            this.Email = model.Email;
            this.City = model.City;
            this.DateAlter = model.DateAlter;
            this.DateCreate = model.DateCreate;
            this.Status = (int)model.Status;
            this.Linkedin = model.Linkedin;
            this.Name = model.Name;
            this.Phone = model.Phone;
            this.Portfolio = model.Portfolio;
            this.QuestionBestTime = !string.IsNullOrEmpty(model.QuestionBestTime) ? model.QuestionBestTime.Split(';').Select(x => Convert.ToInt32(x)).ToArray() : new int[0];
            this.QuestionWillingness = !string.IsNullOrEmpty(model.QuestionWillingness) ? model.QuestionWillingness.Split(';').Select(x => Convert.ToInt32(x)).ToArray() : new int[0];
            this.SalaryHour = model.SalaryHour;
            this.Skype = model.Skype;
            this.State = model.State;
            this.OtherTechnology = model.OtherTechnology;
            this.LinkCRUD = model.LinkCRUD;

            this.Rates = model.Rates != null ? model.Rates.Select(x => new RateModelView
            {
                DateAlter = x.DateAlter,
                DateCreate = x.DateCreate,
                Id = x.Id,
                IdTalent = x.IdTalent,
                Rate = x._Rate.ToString(),
                Status = (int)x.Status,
                TypeTechnology = (int)x.idTypeTechnology
            }).ToList() : null;


            this.Bank = model.Bank != null ? new BankModelView
            {
                Agency = model.Bank.Agency,
                CPF = model.Bank.CPF,
                DateAlter = model.Bank.DateAlter,
                DateCreate = model.Bank.DateCreate,
                Id = model.Bank.Id,
                Name = model.Bank.Name,
                NameBank = model.Bank.NameBank,
                Number = model.Bank.Number,
                Status = (int)model.Bank.Status,
                Type = ((int?)model.Bank.Type).ToString()
            } : null;
        }
        //mapeamento feito na mão, poderia ter usado o AutoMapper
        public Talent TalentModelViewToTalent()
        {
            Talent talent = new Talent
            {
                Id = this.Id,
                Name = this.Name,
                Email = this.Email,
                State = this.State,
                City = this.City,
                Skype = this.Skype,
                Phone = this.Phone,
                Linkedin = this.Linkedin,
                Portfolio = this.Portfolio,
                SalaryHour = this.SalaryHour,
                DateAlter = this.DateAlter,
                DateCreate = this.DateCreate,
                Status = (EnumStatus)this.Status,
                OtherTechnology = this.OtherTechnology,
                LinkCRUD = this.LinkCRUD
            };
            if (this.Bank != null)
                talent.Bank = new Bank
                {
                    Id = this.Bank.Id,
                    Name = this.Bank.Name,
                    NameBank = this.Bank.NameBank,
                    Number = this.Bank.Number,
                    CPF = this.Bank.CPF,
                    Agency = this.Bank.Agency,
                    Type = !string.IsNullOrEmpty(this.Bank.Type) ? (EnumTypeAccount?)Convert.ToInt32(this.Bank.Type) : null,
                    DateAlter = this.DateAlter,
                    DateCreate = this.DateCreate,
                    Status = (EnumStatus)this.Status
                };
            talent.QuestionWillingness = string.Empty;
            foreach (int answer in this.QuestionWillingness)
                talent.QuestionWillingness += answer + ";";
            if (talent.QuestionWillingness != string.Empty)
                talent.QuestionWillingness = talent.QuestionWillingness.Remove(talent.QuestionWillingness.Length - 1);

            talent.QuestionBestTime = string.Empty;
            foreach (int answer in this.QuestionBestTime)
                talent.QuestionBestTime += answer + ";";
            if (talent.QuestionBestTime != string.Empty)
                talent.QuestionBestTime = talent.QuestionBestTime.Remove(talent.QuestionBestTime.Length - 1);

            talent.Rates = this.Rates.Where(x => !string.IsNullOrEmpty(x.Rate)).Select(x => new Rate
            {
                Id = x.Id,
                IdTalent = x.IdTalent,
                _Rate = Convert.ToInt32(x.Rate),
                idTypeTechnology = (EnumTypeTechnology)x.TypeTechnology,
                DateAlter = x.DateAlter,
                DateCreate = x.DateCreate,
                Status = (EnumStatus)x.Status
            }).ToList();


            return talent;
        }
    }

    public class BankModelView : BaseModelView
    {

        public string Name { get; set; }
        public string CPF { get; set; }
        public string NameBank { get; set; }
        public string Agency { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }
    }

    public class RateModelView : BaseModelView
    {
        public Guid IdTalent { get; set; }
        public int TypeTechnology { get; set; }
        public string Rate { get; set; }
    }
}