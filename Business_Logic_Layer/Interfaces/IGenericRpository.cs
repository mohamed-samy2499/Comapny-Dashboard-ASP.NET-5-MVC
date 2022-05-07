using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Interfaces
{
    public interface IGenericRpository<T>  where T : class
    {
        Task<T> Get(int? id);
        Task<IEnumerable<T>> GetAll();
        IEnumerable<T> GetAll(Func<T,bool> func);
        Task<int> Add(T item);
        Task<int> Update(T item);
        Task<int> Delete(T item);
    }
}
