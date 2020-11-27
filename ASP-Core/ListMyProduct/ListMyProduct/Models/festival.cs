using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace ListMyProduct.Models
{
    public class festival
    {
        
        public string link { get; set; }
        public string name { get; set; }

        [JsonPropertyName("Image")]

        public string Image { get; set; }

        public string add { get; set; }

        public string timeFirst { get; set; }

        public string timeLast { get; set; }

        public override string ToString() => JsonSerializer.Serialize<festival>(this);

    }
}
