using DataBase.Tables;
using DataBase.Interfaces;
using Car.Models.FillingDB.JSONtypes;

namespace Car.Models.FillingDB
{
    static public class Fill
    {
        static public void Filling(IBrand brand)
        {
            var qwert = Reader.JSONObj();
            foreach (var item in qwert)
            {
                var qwertyu = Root.ToDBModel(item);
                brand.InsertBrandl(qwertyu);
            }
            brand.Save();
        }
    }
}
