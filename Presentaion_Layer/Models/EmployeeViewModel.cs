using Data_Access_Layer.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Presentaion_Layer.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(50, ErrorMessage ="Max length is 50 characters")]
        [MinLength(2, ErrorMessage = "Min length is 2 characters")]
        public string Name { get; set; }
        [RegularExpression("[0-9]{1,3}-[a-zA-Z]{2,15}-[a-zA-Z]{2,15}-[a-zA-Z]{2,15}", ErrorMessage = "Addres like this: 22-Street-City-Country")]
        public string Address { get; set; }
        [DataType(DataType.Currency)]
        [Range (5000,8000, ErrorMessage = "Salary between 5000 and 8000")]
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public DateTime HireDate { get; set; }
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public virtual DepartmentViewModel Department { get; set; }
        public int DistrictId { get; set; }
        public virtual District District { get; set; }
    }
}
