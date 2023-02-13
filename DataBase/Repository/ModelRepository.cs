using DataBase.Interfaces;
using DataBase.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repository
{
    public class ModelRepository : IModel
    {
        private readonly ApplicationContext context;

        public ModelRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public IEnumerable<Model> AllModels => context.Models.ToList();
    }
}
