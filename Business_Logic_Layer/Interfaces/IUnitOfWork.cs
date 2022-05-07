using Business_Logic_Layer.Rpositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Interfaces
{
    public interface IUnitOfWork
    {
        public IEmployeeRepository EmployeeRepository { get; set; }
        public IDepartmentRpository DepartmentRpository { get; set; }

        public ICityRepository CityRepository { get; set; }
        public IDistrictRepository DistrictRepository { get; set; }
        public ICountryRepository CountryRepository { get; set; }


    }
}
