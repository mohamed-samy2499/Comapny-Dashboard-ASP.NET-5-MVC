using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Entities
{
    public class District
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }

        public virtual City City { get; set; } 
        
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
