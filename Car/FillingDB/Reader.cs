using FillingDB.JSONtypes;
using Newtonsoft.Json;

namespace FillingDB
{
    static public class Reader
    {
        static public List<Root> JSONObj()
        {
            var qwe = File.ReadAllText("FillingDB\\response.json");
            return JsonConvert.DeserializeObject<List<Root>>(qwe);
        }
    }
}
