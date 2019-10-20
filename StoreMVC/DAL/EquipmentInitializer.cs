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
                new Equipment() {EquipmentId=1, Manufacturer ="Molten", Title ="Molten GG7X", CategoryId =1, EquipmentPrice=80, Bestseller=false,
                    PictureName ="moltenball.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp", ShortDescription ="opisek" },
                new Equipment() {EquipmentId=2, Manufacturer ="Spalding", Title ="Spalding TF-50", CategoryId =1, EquipmentPrice=180, Bestseller=true,
                    PictureName ="spalding.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp", ShortDescription ="opisek" },
                new Equipment() {EquipmentId=3, Manufacturer ="Spalding", Title ="Spalding TF-150 Youth", CategoryId =1, EquipmentPrice=380, Bestseller=false,
                    PictureName ="spalding2.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp", ShortDescription ="opisek" },
                new Equipment() {EquipmentId=4, Manufacturer ="Wilson", Title ="Wilson NCAA MVP", CategoryId =1, EquipmentPrice=480, Bestseller=true,
                    PictureName ="wilson.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp", ShortDescription ="opisek" },
                new Equipment() {EquipmentId=5, Manufacturer ="Molten", Title ="Molten GL7X", CategoryId =1, EquipmentPrice=480, Bestseller=true,
                    PictureName ="moltenball2.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp", ShortDescription ="opisek" },
                new Equipment() {EquipmentId=6, Manufacturer ="Wilson", Title ="Wilson 3x3", CategoryId =1, EquipmentPrice=70, Bestseller=true,
                    PictureName ="wilson3x3.png", DateAdded = DateTime.Now, Description ="opis pileczki, 6 rozmiar itp", ShortDescription ="opisek" },
                 new Equipment() {EquipmentId=7, Manufacturer ="Spalding", Title ="Spalding Street Phantom", CategoryId =1, EquipmentPrice=380, Bestseller=true,
                    PictureName ="spaldingdark.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp", ShortDescription ="opisek" },
                new Equipment() {EquipmentId=8, Manufacturer ="Jordan", Title ="Jordan Ultra Fly 2", CategoryId =2, EquipmentPrice=780, Bestseller=true,
                    PictureName ="jordanultrafly2.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp", ShortDescription ="opisek"  },
                new Equipment() {EquipmentId=9, Manufacturer ="Tarmak", Title ="Tarmak Shield 500", CategoryId =2, EquipmentPrice=180, Bestseller=true,
                    PictureName ="tarmak500.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp", ShortDescription ="opisek"  },
                new Equipment() {EquipmentId=10, Manufacturer ="Nike", Title ="Nike Precision 3", CategoryId =2, EquipmentPrice=280, Bestseller=true,
                    PictureName ="nikeprecision.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp", ShortDescription ="opisek"  },
                new Equipment() {EquipmentId=11, Manufacturer ="Nike", Title ="Nike Elite 2.0", CategoryId =2, EquipmentPrice=40, Bestseller=true,
                    PictureName ="nikeelite.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp", ShortDescription ="opisek"  },


                new Equipment() {EquipmentId=12, Manufacturer ="Nike", Title ="Nike Jersey", CategoryId =3, EquipmentPrice=419, Bestseller=true,
                    PictureName ="nikeraptors.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp", ShortDescription ="opisek"  },

                new Equipment() {EquipmentId=13, Manufacturer ="Funny Shirts", Title ="Basketball is my Girlfriend T-Shirt", CategoryId =4, EquipmentPrice=45, Bestseller=true,
                    PictureName ="koszulka.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp", ShortDescription ="opisek"  },

                new Equipment() {EquipmentId=14, Manufacturer ="Mitchell&Ness", Title ="Toronto Shorts", CategoryId =5, EquipmentPrice=199, Bestseller=true,
                    PictureName ="shorts.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp", ShortDescription ="opisek"  },
                new Equipment() {EquipmentId=15, Manufacturer ="Hard Work", Title ="Basketball Backpack", CategoryId =6, EquipmentPrice=480, Bestseller=true,
                    PictureName ="backpack.png", DateAdded = DateTime.Now, Description ="opis pileczki, 7 rozmiar itp", ShortDescription ="opisek"  }

            };
            equipment.ForEach(e => context.AllEquipment.AddOrUpdate(e));
            context.SaveChanges();
            
        }
    }
}