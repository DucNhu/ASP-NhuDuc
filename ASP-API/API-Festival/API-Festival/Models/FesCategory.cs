using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Festival.Models
{
    public class FesCategory
    {
        public int id { get; set; }

        public string name { get; set; }

        public string img { get; set; }

        public int active { get; set; }
    }
}
