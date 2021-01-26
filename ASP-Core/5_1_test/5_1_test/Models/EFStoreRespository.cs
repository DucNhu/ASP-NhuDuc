using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5_1_test.Models
{
    public class EFStoreRespository : IStoreRepository 
    {
        private StoreDbContext context;
        public EFStoreRespository(StoreDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<product> Products => context.Products;
    }
}
