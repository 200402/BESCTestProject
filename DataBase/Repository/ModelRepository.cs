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
        public void InsertModel(Model model) => context.Models.Add(model);
        public void DeleteModel(Model model)
        {
            var modelFromDB = context.Models.Find(new object[] { model.Id });
            context.Models.Remove(modelFromDB);
        }
        public void UpdateModel(Model model)
        {
            var modelFromDB = context.Models.Find(new object[] { model.Id });
            modelFromDB.Name = model.Name;
            modelFromDB.Active= model.Active;
            modelFromDB.BrandId = model.BrandId;
        }
        public void Save() => context.SaveChanges();
    }
}
