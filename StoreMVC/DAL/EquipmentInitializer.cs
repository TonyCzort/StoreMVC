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
                new Category() { CategoryId=1, CategoryName = "Balls", CategoryPictureName = "basketball.png", CategoryDescription ="basketballs"},
                new Category() { CategoryId=2, CategoryName = "Shoes n Socks", CategoryPictureName = "shoe.png", CategoryDescription ="all types of shoes"},
                new Category() { CategoryId=3, CategoryName = "Jerseys", CategoryPictureName = "jersey.png", CategoryDescription ="jesrseys"},
                new Category() { CategoryId=4, CategoryName = "Tshirts", CategoryPictureName = "tshirt.png", CategoryDescription ="tshirts"},
                new Category() { CategoryId=5, CategoryName = "Shorts", CategoryPictureName = "shorts.png", CategoryDescription ="shorts"},
                new Category() { CategoryId=6, CategoryName = "Bagpacks", CategoryPictureName = "backpack.png", CategoryDescription ="backpacks"},
                //new Category() { CategoryId=7, CategoryName = "Socksgg", CategoryPcitureName = "sock.png", CategoryDescription ="socks"},
            };

            categories.ForEach(c => context.Category.AddOrUpdate(c));
            context.SaveChanges();

            var equipment = new List<Equipment>
            {
                new Equipment() {EquipmentId=1, Manufacturer ="Molten", Title ="Molten Fiba Ball", CategoryId =1, EquipmentPrice=80, Bestseller=true,
                    PictureName ="moltenball.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp" },

                new Equipment() {EquipmentId=2, Manufacturer ="Molten2", Title ="Molten Fiba Ball2", CategoryId =1, EquipmentPrice=180, Bestseller=true,
                    PictureName ="moltenball2.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp" },

                new Equipment() {EquipmentId=3, Manufacturer ="Molten3", Title ="Molten Fiba Ball3", CategoryId =1, EquipmentPrice=380, Bestseller=true,
                    PictureName ="moltenball3.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp" },

                new Equipment() {EquipmentId=4, Manufacturer ="Molten4", Title ="Molten Fiba Ball4", CategoryId =1, EquipmentPrice=480, Bestseller=true,
                    PictureName ="moltenball4.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp" },
                new Equipment() {EquipmentId=5, Manufacturer ="Molten5", Title ="Molten Fiba Ball5", CategoryId =1, EquipmentPrice=480, Bestseller=true,
                    PictureName ="moltenball4.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp" },

                new Equipment() {EquipmentId=6, Manufacturer ="Molten11", Title ="Molten Fiba Ball11", CategoryId =2, EquipmentPrice=80, Bestseller=true,
                    PictureName ="moltenball.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp" },

                new Equipment() {EquipmentId=7, Manufacturer ="Molten12", Title ="Molten Fiba Ball12", CategoryId =3, EquipmentPrice=180, Bestseller=true,
                    PictureName ="moltenball2.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp" },

                new Equipment() {EquipmentId=8, Manufacturer ="Molten13", Title ="Molten Fiba Ball13", CategoryId =4, EquipmentPrice=380, Bestseller=true,
                    PictureName ="moltenball3.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp" },

                new Equipment() {EquipmentId=9, Manufacturer ="Molten14", Title ="Molten Fiba Ball14", CategoryId =5, EquipmentPrice=480, Bestseller=true,
                    PictureName ="moltenball4.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp" },
                new Equipment() {EquipmentId=10, Manufacturer ="Molten15", Title ="Molten Fiba Ball15", CategoryId =6, EquipmentPrice=480, Bestseller=true,
                    PictureName ="moltenball4.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp" }

            };
            equipment.ForEach(e => context.AllEquipment.AddOrUpdate(e));
            context.SaveChanges();
            
        }
    }
}