using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarvelComicsMQMP
{
    public class ComicsList
    {
        [JsonProperty("items")]
        public List<Comic> Comics { get; set; }
    }
}
