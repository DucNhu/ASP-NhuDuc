using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesProjectMini.Models
{
    public class Movie
    {
        public long MovieID { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public string NameUser { get; set; }

        public float Views { get; set; }

        public string Time { get; set; }

        public string link { get; set; }
    }
}
