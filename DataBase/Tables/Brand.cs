using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Tables
{
    public class Brand
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Active { get; set; }

        public ICollection<Model> Models { get;set; }

        public Brand() 
        { 
            Models = new List<Model>();
        }
    }
}
