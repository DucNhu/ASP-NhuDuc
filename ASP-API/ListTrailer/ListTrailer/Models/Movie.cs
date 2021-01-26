
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

using System.Text.Json;

namespace ListTrailer.Models
{
    public class Movie
    {
        public string link { get; set; }
        public string nameMovie { get; set; }

        public string view { get; set; }
        public string time { get; set; }

        public string title { get; set; }

        [JsonPropertyName("linkIframe")]
        public string linkIframe { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Movie>(this);

    }  
}
