using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Models;

namespace PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.AppContext
{
    public class MACHAVA15Context : DbContext
    {
        public DbSet<Pessoa> pessoas { get; set; }
        public DbSet<Designacao> designacaos { get; set; }
        public DbSet<Congregacao> Congregacao { get; set; }
        public DbSet<Estado> Estado { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            EntityTypeConfiguration<Designacao> ModelDesignacao = modelBuilder.Entity<Designacao>();
            ModelDesignacao.ToTable("TB_Designacao");

            EntityTypeConfiguration<Pessoa> ModelPessoa = modelBuilder.Entity<Pessoa>();
            ModelPessoa.ToTable("TB_Pessoa");

 

            
          

        }
    }
}