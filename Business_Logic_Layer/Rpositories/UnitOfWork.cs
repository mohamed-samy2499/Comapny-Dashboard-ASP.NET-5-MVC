using Business_Logic_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Rpositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IEmployeeRepository EmployeeRepository { get; set; }
        public IDepartmentRpository DepartmentRpository { get; set; }
        public UnitOfWork(IEmployeeRepository employeeRepository, IDepartmentRpository departmentRpository)
        {
            EmployeeRepository = employeeRepository;    
            DepartmentRpository = departmentRpository;

        }
    }
}
