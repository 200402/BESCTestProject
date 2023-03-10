using Car.Models.FillingDB.JSONtypes;
using Newtonsoft.Json;

namespace Car.Models.FillingDB
{
    static public class Reader
    {
        static public List<Root> JSONObj()
        {
            var fullJson = File.ReadAllText("wwwroot/response.json");
            return JsonConvert.DeserializeObject<List<Root>>(fullJson);
        }
    }
}
