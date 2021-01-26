using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace _5_1_test.Models
{
    public class product
    {
        public long productID { get; set; }

        public string Name { get; set; }

        public string Des { get; set; }
        
        [Column(TypeName = "decimal(8,2)")]   
        public decimal Price { get; set; }

        public string Category { get; set; }
    }
}
