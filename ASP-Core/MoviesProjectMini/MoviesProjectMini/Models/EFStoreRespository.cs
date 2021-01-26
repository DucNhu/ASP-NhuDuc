using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesProjectMini.Models
{
    public class EFStoreRespository : IStoreRespository
    {
        private StoreDbContext context;
        public EFStoreRespository(StoreDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Movie> Movies => context.Movies;

    }
}
