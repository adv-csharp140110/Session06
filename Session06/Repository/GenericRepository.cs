using Session06.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session06.Repository
{
    public class GenericRepository<T>
        where T : class
    {
        AppDbContext context;


        public GenericRepository()
        {
            context= new AppDbContext();
        }
        
        public void Create(T model)
        {
            context.Set<T>().Add(model);
            context.SaveChanges();
        }

        public void Update(T model)
        {
            context.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(T model)
        {
            context.Set<T>().Remove(model);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var model = Find(id);
            context.Set<T>().Remove(model);
            context.SaveChanges();
        }

        public T Find(int id) {
            return context.Set<T>().Find(id);
        }


        public IQueryable<T> AsQueryable() {
            return context.Set<T>().AsQueryable();
        }

    }
}
