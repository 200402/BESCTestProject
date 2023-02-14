using DataBase.Tables;
using FillingDB.JSONtypes;
using FillingDB;
using DataBase.Interfaces;

namespace Car.FillingDB
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
