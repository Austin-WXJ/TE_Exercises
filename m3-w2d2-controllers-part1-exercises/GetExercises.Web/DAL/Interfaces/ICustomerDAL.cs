using GetExercises.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetExercises.Web.DAL.Interfaces
{
    public interface ICustomerDAL
    {
        IList<Customer> SearchForCustomers(string search, string sortBy);
    }
}
