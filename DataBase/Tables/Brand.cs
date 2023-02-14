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
        public int Active { 
            get 
            {
                var a = 0;
                foreach (var b in Brands) 
                {
                    a += b.Active;
                } return a;
            }
            set { }
        }

        public ICollection<Model> Brands { get;set; }

        public Brand() 
        { 
            Brands = new List<Model>();
        }
    }
}
