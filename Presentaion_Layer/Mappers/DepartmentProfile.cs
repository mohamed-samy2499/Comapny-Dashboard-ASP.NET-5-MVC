using AutoMapper;
using Data_Access_Layer.Entities;
using Presentaion_Layer.Models;

namespace Presentaion_Layer.Mappers
{
    public class DepartmentProfile:Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Department, DepartmentViewModel>().ReverseMap();
        }
    }
}
