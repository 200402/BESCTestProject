using DataBase.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Interfaces
{
    public interface IBrand
    {
        IEnumerable<Brand> AllBrands { get; }
    }
}
