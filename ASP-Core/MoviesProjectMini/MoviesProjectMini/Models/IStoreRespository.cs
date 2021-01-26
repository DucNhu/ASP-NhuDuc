using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesProjectMini.Models
{
    public interface IStoreRespository
    {
        IQueryable<Movie> Movies { get; }
    }
}
