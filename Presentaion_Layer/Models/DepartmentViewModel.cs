using System.ComponentModel.DataAnnotations;

namespace Presentaion_Layer.Models
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        public int Code { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(50, ErrorMessage = "Max length is 50 characters")]
        [MinLength(2, ErrorMessage = "Min length is 2 characters")]
        public string Name { get; set; }
    }
}
