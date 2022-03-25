using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Interfaces
{
    public interface IGenericRpository<T>  where T : class
    {
        T Get(int? id);
        IEnumerable<T> GetAll();
        int Add(T item);
        int Update(T item);
        int Delete(T item);
    }
}
