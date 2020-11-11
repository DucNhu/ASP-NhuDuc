using System;
using System.Collections.Generic;

namespace Newspaper1.Models
{
    public partial class News
    {
        public int NewsId { get; set; }
        public string Sections { get; set; }

        public Post Post { get; set; }
    }
}
