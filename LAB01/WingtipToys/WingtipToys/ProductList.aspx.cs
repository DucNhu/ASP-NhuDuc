using System;
using System.Collections.Generic;
using System.Linq;
using WingtipToys.Models;
using System.Web.ModelBinding;

namespace WingtipToys  
{
    public partial class ProductList : System.Web.UI.Page
    {
        public IQueryable<Product> GetProducts([QueryString("id")] int? categoryId)
        {
            var _db = new WingtipToys.Models.ProductContext();
            IQueryable<Product> query = _db.Products;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            return query;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void productList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}