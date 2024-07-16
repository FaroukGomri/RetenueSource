using RetenueSource.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace RetenueSource.Data
{
    public class RetenueSourceContext : DbContext
    {
        public DbSet<Beneficiere> Beneficieres { get; set; }
        public DbSet<EnteteRetenueSource> EnteteRetenueSources { get; set; }
        public DbSet<LigneRetenueSource> LigneRetenueSources { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Program.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Beneficiere>().ToTable("F_Beneficiere");
            modelBuilder.Entity<EnteteRetenueSource>().ToTable("F_EnteteRetenueSource");
            modelBuilder.Entity<LigneRetenueSource>().ToTable("F_LigneRetenueSource");
            modelBuilder.Entity<LigneRetenueSource>()
            .HasOne<EnteteRetenueSource>()
            .WithMany(e => e.LigneRetenueSources)
            .HasForeignKey(l => l.EnteteRetenueSourceId);
        }
    }
}
