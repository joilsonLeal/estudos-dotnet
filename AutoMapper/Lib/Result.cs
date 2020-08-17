using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Lib
{
    public class Result
    {
        [JsonPropertyName("anime")]
        public List<Anime> Animes { get; set; }
    }
}
