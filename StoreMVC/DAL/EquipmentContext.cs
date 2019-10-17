using StoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;


//Data Access Layer
namespace StoreMVC.DAL
{
    public class EquipmentContext : DbContext
    {
        public EquipmentContext() : base("EquipmentContext")
        {

        }

        //wywoalanie initializera
        static EquipmentContext()
        {
            Database.SetInitializer<EquipmentContext>(new EquipmentInitializer());
        }

        public DbSet<Equipment> AllEquipment { get; set; } //DbSet to tabela
        public DbSet<Category> Category { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // using System.Data.Entity.ModelConfiguration.Conventions;
            // Wyłącza konwencję, która automatycznie tworzy liczbę mnogą dla nazw tabel w bazie danych
            // Zamiast Kategorie zostałaby stworzona tabela o nazwie Kategories
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}