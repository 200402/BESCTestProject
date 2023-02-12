using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Tables
{
    public class Brand
    {
        public int? Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Active { get; set; } = string.Empty; // И зачем это здесь?

        public ICollection<Model> Brands { get;set; }
        public Brand() { Brands = new List<Model>(); }
    }
}
