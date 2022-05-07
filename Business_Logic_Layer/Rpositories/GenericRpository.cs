using Business_Logic_Layer.Interfaces;
using Data_Access_Layer.Contexts;
using Microsoft.EntityFrameworkCore;
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
        public async Task<int> Add(T item)
        {
            await context.Set<T>().AddAsync(item);
            return await context.SaveChangesAsync();
        }

        public async Task<int> Delete(T item)
        {
            context.Set<T>().Remove(item);
            return await context.SaveChangesAsync();
        }

        public async Task<T> Get(int? id)
        => await context.Set<T>().FindAsync(id);

        public async Task<IEnumerable<T>> GetAll()
        => await context.Set<T>().ToListAsync();   

        public IEnumerable<T> GetAll(Func<T,bool> func)
            => context.Set<T>().Where(func).ToList();
        public async Task<int> Update(T item)
        {
            context.Set<T>().Update(item);
            return await context.SaveChangesAsync();  
        }
    }
}
