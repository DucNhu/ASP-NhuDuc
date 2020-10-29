using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace w02.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        //Add data in db
        protected override void Seed(ProductContext context)
        {
                GetCategories().ForEach(c => context.Categories.Add(c));
                GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> 
            {
                new Category {
                    CategoryID = 1,
                    CategoryName = "Cars"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Planes"
                }

            };
            return categories;
        }

        private static List<Product> GetProducts()
        {
            var Products = new List<Product>
            {
                new Product {
                    ProductID = 1,
                    productname = "Convertible Car",
                    Description = "This convertible car is fast! The engine is"+
                    "powered by a neutrino based battery (not included)." +
                    "Power it up and let it go!",
                    ImagePath="carconvert.png",
                    UnitPrice = 22.50,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 2,
                    productname = "Convertible Car",
                    Description = "This convertible car is fast! The engine is"+
                    "powered by a neutrino based battery (not included)." +
                    "Power it up and let it go!",
                    ImagePath="carconvert.png",
                    UnitPrice = 22.50,
                    CategoryID = 1
                }

            };
            return Products;
        }

    }

    
}