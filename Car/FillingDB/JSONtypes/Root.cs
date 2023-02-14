using DataBase.Tables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingDB.JSONtypes
{
    public class Root
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;

        [JsonProperty("cyrillic-name")]
        public string Cyrillicname { get; set; } = string.Empty;
        public bool Popular { get; set; }
        public string Country { get; set; } = string.Empty;
        public List<ModelJSON> Models { get; set; } = new List<ModelJSON>();

        public static Brand ToDBModel(Root root) => new Brand
        {
            Id = Guid.NewGuid(),
            Name = root.Name,
            Brands = ModelJSON.ToDBModels(root.Models)
        };
    }
}
