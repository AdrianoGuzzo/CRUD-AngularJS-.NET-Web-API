namespace TalentsCRUD.DBContext.Migrations
{
    using Model;
    using Model.Tools;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TalentsCRUD.DBContext.DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TalentsCRUD.DBContext.DBContext context)
        {
            foreach (EnumTypeTechnology typeTechnology in Enum.GetValues(typeof(EnumTypeTechnology)))
            {
                context.TypeTechnology.AddOrUpdate(
                    new TypeTechnology
                    {
                        Id = typeTechnology,
                        Description = Util.StringValueOfEnum(typeTechnology),
                    }
                );
                
            }
            context.Talent.AddOrUpdate(
                    new Talent
                    {
                        Name = "Adriano Guzzo Rosa",
                        City = "Curitiba",
                        State = "PR",
                        DateCreate = DateTime.Now,
                        Email = "adriano.guzzo@gmail.com",
                        LinkCRUD = "https://github.com/AdrianoGuzzo/CRUD-AngularJS-.NET-Web-API",
                        Id = Guid.NewGuid(),
                        Linkedin = "www.linkedin.com/in/adriano-guzzo",
                        Phone = "(41)99733-7052",
                        QuestionBestTime = "4;5",
                        QuestionWillingness = "3",
                        SalaryHour = 35,
                        Skype = "adriano_guzzo@hotmail.com",
                        Status = EnumStatus.Active,
                        Bank = new Bank
                        {
                            Name = "Adriano Guzzo Rosa",
                            Agency = "0942",
                            DateCreate = DateTime.Now,
                            NameBank = "ITAU",
                            Number = "11387-9",
                            Status = EnumStatus.Active,
                            Type = EnumTypeAccount.Chain
                        },
                        Rates = new List<Rate>() { new Rate {
                            Id=Guid.NewGuid(),
                            Status=EnumStatus.Active,
                            DateCreate=DateTime.Now,
                            idTypeTechnology=EnumTypeTechnology.Ionic,
                            _Rate=0
                        },new Rate {
                            Id=Guid.NewGuid(),
                            Status=EnumStatus.Active,
                            DateCreate=DateTime.Now,
                            idTypeTechnology=EnumTypeTechnology.Android,
                            _Rate=2
                        },new Rate {
                            Id=Guid.NewGuid(),
                            Status=EnumStatus.Active,
                            DateCreate=DateTime.Now,
                            idTypeTechnology=EnumTypeTechnology.IOS,
                            _Rate=0
                        },new Rate {
                            Id=Guid.NewGuid(),
                            Status=EnumStatus.Active,
                            DateCreate=DateTime.Now,
                            idTypeTechnology=EnumTypeTechnology.Bootstrap,
                            _Rate=3
                        }, new Rate {
                            Id=Guid.NewGuid(),
                            Status=EnumStatus.Active,
                            DateCreate=DateTime.Now,
                            idTypeTechnology=EnumTypeTechnology.AngularJs,
                            _Rate=1
                        }, new Rate {
                            Id=Guid.NewGuid(),
                            Status=EnumStatus.Active,
                            DateCreate=DateTime.Now,
                            idTypeTechnology=EnumTypeTechnology.AspNetMVC,
                            _Rate=5
                        }, new Rate {
                            Id=Guid.NewGuid(),
                            Status=EnumStatus.Active,
                            DateCreate=DateTime.Now,
                            idTypeTechnology=EnumTypeTechnology.PHP,
                            _Rate=1
                        }, new Rate {
                            Id=Guid.NewGuid(),
                            Status=EnumStatus.Active,
                            DateCreate=DateTime.Now,
                            idTypeTechnology=EnumTypeTechnology.Wordpress,
                            _Rate=0
                        },new Rate {
                            Id=Guid.NewGuid(),
                            Status=EnumStatus.Active,
                            DateCreate=DateTime.Now,
                            idTypeTechnology=EnumTypeTechnology.MySQLServer,
                            _Rate=4
                        }, new Rate {
                            Id=Guid.NewGuid(),
                            Status=EnumStatus.Active,
                            DateCreate=DateTime.Now,
                            idTypeTechnology=EnumTypeTechnology.MySQL,
                            _Rate=1
                        },}

                    }
                );
        }
    }
}
