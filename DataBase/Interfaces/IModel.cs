using DataBase.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Interfaces
{
    public interface IModel
    {
        IEnumerable<Model> AllModels { get; }
        void InsertModel(Model model);
        void UpdateModel(Model model);
        void DeleteModel(Model model);
        void Save();
    }
}
