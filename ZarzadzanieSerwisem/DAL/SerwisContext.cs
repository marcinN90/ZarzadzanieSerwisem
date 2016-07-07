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
            Database.SetInitializer<SerwisContext>(new Initializer());
        }
        public DbSet<PrzyjeteUrzadzenie> Serwisowane { get; set; }
        public DbSet<Magazynier> Magazynier { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Potrzebne dla klas Identity
            base.OnModelCreating(modelBuilder);
            // using System.Data.Entity.ModelConfiguration.Conventions;
            // Wyłącza konwencję, która automatycznie tworzy liczbę mnogą dla nazw tabel
            // w bazie danych
            // Zamiast Kategorie zostałaby utworzona tabela o nazwie Kategories
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
           
        }
     
    }
}