using ApplicationCore.Domain;
using Exam.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Infrastructure
{
    public class ExamContext: DbContext
    {
        //les dbsets
        public DbSet<Client> Client { get; set; }
        public DbSet<Prestataire> Prestataires { get; set; }

        public DbSet<Prestation> Prestations { get; set; }

        public DbSet<RDV> RDVs { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;

             Initial Catalog=BeautyHarounJlassi;Integrated Security=true;
                  MultipleActiveResultSets=true");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        //appliquer le fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //appel de la classe de configuration
            modelBuilder.ApplyConfiguration(new RDVConfiguration());

            base.OnModelCreating(modelBuilder);
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //pre configuration
            configurationBuilder.Properties<string>().HaveMaxLength(150);

            base.ConfigureConventions(configurationBuilder);
        }
    }
}
