using AutoMapper;
using Data_Access_Layer.Entities;
using Presentaion_Layer.Models;

namespace Presentaion_Layer.Mappers
{
    public class EmployeeProfile:Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee,EmployeeViewModel>().ReverseMap();
        }
    }
}
