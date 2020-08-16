using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _02.Model
{
    public class Anime
    {
        [JsonPropertyName("mal_id")]
        public int Mal_id { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("image_url")]
        public string Image_url { get; set; }
        [JsonPropertyName("synopsis")]
        public string Synopsis { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("airing_start")]
        public DateTime Airing_start { get; set; }
        [JsonPropertyName("episodes")]
        public int? Episodes { get; set; }

    }
}
