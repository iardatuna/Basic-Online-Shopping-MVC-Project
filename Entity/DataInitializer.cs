using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TunaETradeProject.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Category> categories = new List<Category>
            {
                new Category () {Name="Camera", Description="Cam Products"},
                new Category () {Name="Mobile Phone", Description="Mobile Phone Products"},
                new Category () {Name="Computer", Description="Computer Products"},
                new Category () {Name="Laptop", Description="Laptop Products"},
                new Category () {Name="PS4", Description="PS4 Products"},

            };

            foreach (var category in categories)
            {
                context.Categories.Add(category);
            }
            context.SaveChanges();

            List<Product> products = new List<Product>
            {
                new Product(){ Name ="Dell Xps 15", Description="Best Computer Ever", Price= 12000, Stock=120, IsApproved=true, CategoryId=4, IsAtHomePage=true },
                new Product(){ Name ="Macbook Pro", Description="Second Best Computer Ever", Price= 14000, Stock=1200, IsApproved=true, CategoryId=4 },
                new Product(){ Name ="Kodak JG4", Description="Best Camera Ever", Price= 1200, Stock=120, IsApproved=true, CategoryId=1, IsAtHomePage=true},
                new Product(){ Name ="Iphone 11", Description="Best Forever", Price= 1200, Stock=190, IsApproved=false, CategoryId=2, IsAtHomePage=true },
                new Product(){ Name ="Samsung S12", Description="Best Touch Ever", Price= 1200, Stock=126, IsApproved=false, CategoryId=2 },
                new Product(){ Name ="Huawei 5", Description="Best Mobile Ever", Price= 1200, Stock=177, IsApproved=true, CategoryId=2 , IsAtHomePage=true},
                new Product(){ Name ="Asus Zenbook 15", Description="Best Computer Ever", Price= 1200, Stock=135, IsApproved=false, CategoryId=3 , IsAtHomePage=true},
                new Product(){ Name ="Monster X8", Description="Feel like a Monster", Price= 1200, Stock=123, IsApproved=false, CategoryId=3 },
                new Product(){ Name ="PS4 Dualshock", Description="Best Touch Ever", Price= 200, Stock=134, IsApproved=true, CategoryId=4 , IsAtHomePage=true},
                new Product(){ Name ="PS Vita", Description="Best Smoothness Ever", Price= 100, Stock=124, IsApproved=false, CategoryId=4 , IsAtHomePage=true},
                new Product(){ Name ="PS VR", Description="Best Experience Ever", Price= 1200, Stock=10, IsApproved=true, CategoryId=4 },
                new Product(){ Name ="Fifa 20", Description="Best Game Ever", Price= 1700, Stock=20, IsApproved=true, CategoryId=4 , IsAtHomePage=true},




            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}