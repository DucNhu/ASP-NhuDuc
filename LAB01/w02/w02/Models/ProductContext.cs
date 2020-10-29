using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; //bạn có quyền truy cập vào tất cả lõi chức năng của Entity Framework

namespace w02.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("w02") { }
        public DbSet<Category>  Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
     
}