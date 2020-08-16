using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _02.Model
{
    public class Result
    {
        [JsonPropertyName("anime")]
        public List<Anime> Animes { get; set; }
    }
}
