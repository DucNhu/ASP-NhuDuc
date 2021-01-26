using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Festival.Models
{
    public class Festival
    {
        public int id { get; set; }

        public string NameCategory { get; set; }

        public string NameNav { get; set; }

        public string name { get; set; }

        public string img { get; set; }

        public string address { get; set; }

        public string timeFirst { get; set; }

        public string timeLast { get; set; }

        public float price { get; set; }

        public int sale { get; set; }

        public string description { get; set; }

    }
}
