using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public class AnimeDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Synopsis { get; set; }
        public string Type { get; set; }
        public DateTime Start { get; set; }
        public int? Episodes { get; set; }
    }
}
