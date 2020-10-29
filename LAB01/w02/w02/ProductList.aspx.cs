using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;
using w02.Models;

namespace w02
{
    public partial class ProductList : System.Web.UI.Page
    {
        public IQueryable<Product> GetProducts([QueryString("id")] int? categoryId)
        {
            var _db = new w02.Models.ProductContext();
                IQueryable<Product> query = _db.Products;
            if(categoryId.HasValue && categoryId > 0)
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