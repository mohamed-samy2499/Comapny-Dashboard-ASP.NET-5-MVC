using Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Interfaces
{
    public interface IEmployeeRepository:IGenericRpository<Employee>
    {
        Task<IEnumerable<Employee>> GetEmployeeAndDepartment();
        IEnumerable<Employee> SearchEmployeeAndDepartment(Func<Employee,bool> func);
    }
}
