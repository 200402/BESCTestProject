using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Tables
{
    public class Model
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Active { get; set; }

        public Guid BrandId { get; set; }
        public Brand Brand { get; set; } = new();
    }
}
