namespace TalentsCRUD.DBContext.Migrations
{
    using Model;
    using Model.Tools;
    using System;
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
                    new TypeTechnology {
                        Id = typeTechnology,
                        Description =Util.StringValueOfEnum(typeTechnology),                        
                    }
                );               
            }
        }
    }
}
