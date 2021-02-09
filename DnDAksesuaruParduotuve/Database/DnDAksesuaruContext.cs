using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DnDAksesuaruParduotuve
{
    public class DnDAksesuaruContext : DbContext
    {
        public DnDAksesuaruContext() : base("DnDAksesuaruParduotuve")
        {
            Database.SetInitializer(new DnDAksesuaruContextInitializer());
        }

        public DbSet<Preke> Prekes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Preke>()
                        .ToTable("Prekes")
                        .HasKey(k => k.PrekeId)
                        .Ignore(pk => pk.PasirinktasKiekis);

            modelBuilder.Entity<Preke>()
                        .Property(p => p.Pavadinimas)
                        .IsRequired();

            modelBuilder.Entity<Preke>()
                        .Property(p => p.Kategorija)
                        .IsRequired();

            modelBuilder.Entity<Preke>()
                        .Property(p => p.Kaina)
                        .IsRequired();

            modelBuilder.Entity<Preke>()
                        .Property(p => p.Svoris)
                        .IsRequired();

            modelBuilder.Entity<Preke>()
                        .Property(p => p.TurimasKiekis)
                        .IsRequired();
        }
    }
}
