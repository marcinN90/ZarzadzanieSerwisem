using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using ZarzadzanieSerwisem.Models;

namespace ZarzadzanieSerwisem.DAL
{
    public class SerwisContext : DbContext
    {
        public SerwisContext()  : base("SerwisContext")
        {
           // Database.SetInitializer<SerwisContext>(new Initializer());
        }
        public DbSet<PrzyjeteUrzadzenie> PrzyjeteUrzadzenie { get; set; }
        public DbSet<Magazynier> Magazynier { get; set; }
        public DbSet<Serwisant> Serwisant { get; set; }
        public DbSet<StatusNaprawy> StatusNaprawy { get; set; }
        public DbSet<StatusMagazynowy> StatusMagazynowy { get; set; }
        public DbSet<Usterka> Usterka { get; set; }
        public DbSet<UrzadzNapr> UrzadzNapr { get; set; }  
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Potrzebne dla klas Identity
            base.OnModelCreating(modelBuilder);
            // using System.Data.Entity.ModelConfiguration.Conventions;
            // Wyłącza konwencję, która automatycznie tworzy liczbę mnogą dla nazw tabel
            // w bazie danych
            // Zamiast Kategorie zostałaby utworzona tabela o nazwie Kategories
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

        }

    
    }
}