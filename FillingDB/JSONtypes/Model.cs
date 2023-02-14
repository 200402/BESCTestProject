using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingDB.JSONtypes
{
    public class Model
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;

        [JsonProperty("cyrillic-name")]
        public string Cyrillicname { get; set; } = string.Empty;
        public string @Class { get; set; } = string.Empty;

        [JsonProperty("year-from")]
        public int Yearfrom { get; set; }

        [JsonProperty("year-to")]
        public int? Yearto { get; set; }
    }
}
