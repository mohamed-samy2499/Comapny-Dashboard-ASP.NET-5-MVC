using Business_Logic_Layer.Interfaces;
using Data_Access_Layer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Rpositories
{
    public class GenericRpository<T> : IGenericRpository<T> where T : class
    {
        private readonly AppDbContext context;

        public GenericRpository(AppDbContext context)
        {
            this.context = context;
        }
        public int Add(T item)
        {
            context.Set<T>().Add(item);
            return context.SaveChanges();
        }

        public int Delete(T item)
        {
            context.Set<T>().Remove(item);
            return context.SaveChanges();
        }

        public T Get(int? id)
        => context.Set<T>().Find(id);

        public IEnumerable<T> GetAll()
        => context.Set<T>().ToList();   

        public int Update(T item)
        {
            context.Set<T>().Update(item);
            return context.SaveChanges();  
        }
    }
}
