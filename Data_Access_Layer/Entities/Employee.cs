using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(2)]
        public string Name { get; set; }
        [RegularExpression("[0-9]{1,3}-[a-zA-Z]{2,15}-[a-zA-Z]{2,15}-[a-zA-Z]{2,15}")]
        public string Address { get; set; }
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public string Email { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public int DistrictId { get; set; }
        public virtual District District { get; set; }

    }
}
