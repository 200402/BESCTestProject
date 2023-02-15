using DataBase.Tables;
using DataBase.Interfaces;
using Car.Models.FillingDB.JSONtypes;

namespace Car.Models.FillingDB
{
    static public class Fill
    {
        static public void Filling(IBrand brandRepository)
        {
            if (brandRepository.AllBrands.Count() == 0)
            {
                var brandJSONs = Reader.JSONObj();
                foreach (var brandJSON in brandJSONs)
                {
                    var brand = Root.ToDBModel(brandJSON);
                    int i = 0;
                    foreach (var model in brand.Models)
                    {
                        i += model.Active;
                    }
                    brand.Active = i;
                    brandRepository.InsertBrandl(brand);
                }
            }
            else
            {
                Random random= new Random();
                foreach (var brand in brandRepository.AllBrands)
                {
                    int i = 0;
                    foreach (var model in brand.Models)
                    {
                        model.Active = random.Next(20);
                        i += model.Active;
                    }
                    brand.Active = i;
                }
            }
            brandRepository.Save();
        }
    }
}
