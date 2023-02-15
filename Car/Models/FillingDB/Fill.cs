using DataBase.Tables;
using DataBase.Interfaces;
using Car.Models.FillingDB.JSONtypes;

namespace Car.Models.FillingDB
{
    static public class Fill
    {
        static public void Filling(IBrand brandRepository)
        {
            var brands = Reader.JSONObj();
            foreach (var brandJSON in brands)
            {
                var brand = Root.ToDBModel(brandJSON);
                int i = 0;
                foreach (var Model in brand.Models)
                {
                    i += Model.Active;
                }
                brand.Active = i;
                brandRepository.InsertBrandl(brand);
            }
            brandRepository.Save();
        }
    }
}
