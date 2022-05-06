using Business_Logic_Layer.Interfaces;
using Data_Access_Layer.Contexts;
using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Rpositories
{
    public class EmployeeRepository: GenericRpository<Employee>,IEmployeeRepository
    {
        private readonly AppDbContext context;

        public EmployeeRepository(AppDbContext context):base(context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Employee>> GetEmployeeAndDepartment()
        {
            return await context.Employees.Include(E => E.Department).ToListAsync();

        }
        public  IEnumerable<Employee> SearchEmployeeAndDepartment(Func<Employee, bool> func)
        {
            return context.Employees.Include(E => E.Department).Where(func).ToList();

        }
    }
}
