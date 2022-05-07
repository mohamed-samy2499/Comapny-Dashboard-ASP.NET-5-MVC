using Business_Logic_Layer.Interfaces;
using Data_Access_Layer.Contexts;
using Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Rpositories
{
    public class CityRpository:GenericRpository<City>,ICityRepository
    {

        public CityRpository(AppDbContext context):base(context)
        {
        }

    }
}
