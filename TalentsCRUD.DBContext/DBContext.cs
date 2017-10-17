namespace TalentsCRUD.DBContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using Model;

    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
            Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Talent> Talent { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<TypeTechnology> TypeTechnology { get; set; }
        public DbSet<Rate> Rate { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Talent>()
              .HasOptional(s => s.Bank)
              .WithRequired(ad => ad.Talent);

            modelBuilder.Entity<Rate>()
               .HasRequired<TypeTechnology>(s => s.TypeTechnology)
               .WithMany(g => g.Rates)
               .HasForeignKey<EnumTypeTechnology>(s => s.idTypeTechnology);

            modelBuilder.Entity<Rate>()
                .HasRequired<Talent>(s => s.Talent)
                .WithMany(g => g.Rates)
                .HasForeignKey<Guid>(s => s.IdTalent);

            base.OnModelCreating(modelBuilder);
        }
    }
}
