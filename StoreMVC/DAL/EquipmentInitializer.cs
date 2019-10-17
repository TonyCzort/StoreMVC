using StoreMVC.Migrations;
using StoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace StoreMVC.DAL
{
    /// <summary>
    /// initializer sluzy do budowy naszej bazy danychW
    /// </summary>

    //drop create database always - baza usuwana i tworzona zawsze
    //drop create database if model changes - baza kasowana i tworzona przy zmianach modelu
    public class EquipmentInitializer : MigrateDatabaseToLatestVersion<EquipmentContext, Configuration>
    {
        

        public static void SeedEquimpentData(EquipmentContext context)
        {
            var categories = new List<Category>
            {
                new Category() { CategoryId=1, CategoryName = "Balls", CategoryPcitureName = "basketball.png", CategoryDescription ="basketballs"},
                new Category() { CategoryId=2, CategoryName = "Shoes", CategoryPcitureName = "shoe.png", CategoryDescription ="all types of shoes"},
                new Category() { CategoryId=3, CategoryName = "Jerseys", CategoryPcitureName = "jersey.png", CategoryDescription ="jesrseys"},
                new Category() { CategoryId=4, CategoryName = "Tshirts", CategoryPcitureName = "tshirt.png", CategoryDescription ="tshirts"},
                new Category() { CategoryId=5, CategoryName = "Shorts", CategoryPcitureName = "shorts.png", CategoryDescription ="shorts"},
                new Category() { CategoryId=6, CategoryName = "Bagpacks", CategoryPcitureName = "backpack.png", CategoryDescription ="backpacks"},
                new Category() { CategoryId=7, CategoryName = "Socks", CategoryPcitureName = "sock.png", CategoryDescription ="socks"},
            };

            categories.ForEach(c => context.Category.AddOrUpdate(c));
            context.SaveChanges();

            var equipment = new List<Equipment>
            {
                new Equipment() {Manufacturer ="Molten", Title ="Molten Fiba Ball", CategoryId =1, EquipmentPrice=80, Bestseller=true,
                    PictureName ="moltenball.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp" },

                new Equipment() {Manufacturer ="Molten2", Title ="Molten Fiba Ball2", CategoryId =1, EquipmentPrice=180, Bestseller=true,
                    PictureName ="moltenball2.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp" },

                new Equipment() {Manufacturer ="Molten3", Title ="Molten Fiba Ball3", CategoryId =1, EquipmentPrice=380, Bestseller=true,
                    PictureName ="moltenball3.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp" },

                new Equipment() {Manufacturer ="Molten4", Title ="Molten Fiba Ball4", CategoryId =1, EquipmentPrice=480, Bestseller=true,
                    PictureName ="moltenball4.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp" },

            };
            equipment.ForEach(e => context.AllEquipment.AddOrUpdate(e));
            context.SaveChanges();
            
        }
    }
}