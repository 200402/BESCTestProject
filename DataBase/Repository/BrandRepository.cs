using DataBase.Interfaces;
using DataBase.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repository
{
    public class BrandRepository : IBrand
    {
        private readonly ApplicationContext context;


        public BrandRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public IEnumerable<Brand> AllBrands => context.Brands.ToList();

        public void InsertBrand(Brand brand) => context.Brands.Add(brand);

        public void Save() => context.SaveChanges();

        public void UpdateBrand(Brand brand)
        {
            var brandFromDB = context.Brands.Find(new object[] { brand.Id });
            brandFromDB.Name = brand.Name;
            // TODO: сделать связь с моделями
        }

        public void DeleteBrand(Brand brand)
        {
            var brandFromDB = context.Brands.Find(new object[] { brand.Id });
            context.Brands.Remove(brandFromDB);
        }
    }
}
