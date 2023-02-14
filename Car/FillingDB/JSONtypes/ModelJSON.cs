using DataBase.Tables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingDB.JSONtypes
{
    public class ModelJSON 
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


        private static Random rand = new Random();

        public static Model ToDBModel(ModelJSON modelJSON) => new Model
        {
            Name = modelJSON.Name,
            Active = rand.Next(20),
        };

        public static List<Model> ToDBModels(List<ModelJSON> modelJSONs)
        {
            List<Model> models = new List<Model>();
            foreach (ModelJSON modelJSON in modelJSONs)
            {
                models.Add(ToDBModel(modelJSON));
            }
            return models;
        }
    }
}
