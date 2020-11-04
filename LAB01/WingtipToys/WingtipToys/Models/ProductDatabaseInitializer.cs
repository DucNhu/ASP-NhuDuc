using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WingtipToys.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Cars"
                },

                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Planes"
                },

                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Trucks"
                },

                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Boats"
                },

                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Rockets"
                },
            };
            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {

                new Product
                    {
                    ProductID = 1,
                    ProductName = "Early Truck",

                    Description = "This toy truck has a real gas powered engine.Requires regular tune ups.",
                    ImagePath = "car.jpg",
                    UnitPrice = 15.00,
                    CategoryID = 1
                    },

                new Product
                    {
                    ProductID = 2,
                    ProductName = "Fire Truck",
                    Description = "You will have endless fun with this one quarter sized fire truck.",
                    ImagePath="space.jpg",
                    UnitPrice = 26.00,
                    CategoryID = 2
                    },

                new Product
                    {
                    ProductID = 3,
                    ProductName = "Fire Truck",
                    Description = "You will have endless fun with this one quarter sized fire truck.",
                    ImagePath="space.jpg",
                    UnitPrice = 26.00,
                    CategoryID = 2
                    },

                new Product
                    {
                    ProductID = 4,
                    ProductName = "Paper Boat",
                    Description = "Floating fun for all! This toy boat can beassembled in seconds.Floats for minutes!" +"Some folding required.",
                    ImagePath="tanker.jpg",
                    UnitPrice = 4.95,
                    CategoryID = 3
                    },

                new Product
                    {
                    ProductID = 5,
                    ProductName = "Sail Boat",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="tank.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                    },

                new Product
                    {
                    ProductID = 6,
                    ProductName = "Rocket",
                    Description = "This fun rocket will travel up to a height of 200 feet.",
                    ImagePath = "rocket.jpg",
                    UnitPrice = 122.95,
                    CategoryID = 5
                    }
             };
            return products;
        }
    }
}