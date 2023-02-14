using FillingDB.JSONtypes;
using Newtonsoft.Json;

namespace FillingDB
{
    static public class Reader
    {
        static public List<Root> JSONObj()
        {
            string solutiondir = Directory.GetParent(
                Directory.GetCurrentDirectory()).FullName;
            var qwe = File.ReadAllText(solutiondir + "\\FillingDB\\response.json");
            var obj = JsonConvert.DeserializeObject<List<Root>>(qwe);
            return obj;
        }
    }
}
