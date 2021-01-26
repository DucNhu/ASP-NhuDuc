using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5_1_test.Models
{
    public interface IStoreRepository
    {
        IQueryable<product> Products { get; }
    }
}
