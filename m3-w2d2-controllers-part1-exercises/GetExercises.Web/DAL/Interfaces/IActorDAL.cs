using GetExercises.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetExercises.Web.DAL.Interfaces
{
    public interface IActorDAL
    {
        IList<Actor> FindActors(string lastNameSearch);
    }
}
