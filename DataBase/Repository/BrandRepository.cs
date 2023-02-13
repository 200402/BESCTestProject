using DataBase.Interfaces;
using DataBase.Tables;
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
        private readonly IMemoryCache _memoryCache;


        public BrandRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public IEnumerable<Brand> AllBrands => context.Brands.ToList();
    }
}
