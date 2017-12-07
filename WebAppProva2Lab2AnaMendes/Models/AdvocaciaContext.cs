using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebAppProva2Lab2AnaMendes.Models
{
    public class AdvocaciaContext : DbContext
    {
        public AdvocaciaContext() : base("name=AdvocaciaContext")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //Remoção de datetime para datetime2 classe processo
            modelBuilder.Entity<Processo>()
                .Property(x => x.DataEntrada)
                .HasColumnType("Datetime2");

            modelBuilder.Entity<Processo>()
                .Property(x => x.DataSaida)
                .HasColumnType("Datetime2");

            //Remoção de datetime para datetime2 classe Audiencia
            modelBuilder.Entity<Audiencia>()
                .Property(x => x.Data)
                .HasColumnType("Datetime2");

        }

        
    }
}