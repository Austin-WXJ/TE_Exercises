using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetExercises.Web.Models;

namespace GetExercises.Web.DAL.Interfaces
{
    public interface ICategoryDAL
    {
        IList<string> GetCategories();
    }
}
