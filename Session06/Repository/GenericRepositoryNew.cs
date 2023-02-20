using Session06.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session06.Repository
{
    public class GenericRepositoryNew        
    {
        AppDbContext context;


        public GenericRepositoryNew()
        {
            context= new AppDbContext();
        }
        
        public void Create<T>(T model) where T : class
        {
            context.Set<T>().Add(model);
            context.SaveChanges();
        }

        public void Update<T>(T model)
        {
            context.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete<T>(T model) where T : class
        {
            context.Set<T>().Remove(model);
            context.SaveChanges();
        }

        public void Delete<T>(int id) where T : class
        {
            var model = Find<T>(id);
            context.Set<T>().Remove(model);
            context.SaveChanges();
        }

        public T Find<T>(int id) where T : class
        {
            return context.Set<T>().Find(id);
        }


        public IQueryable<T> AsQueryable<T>() where T : class
        {
            return context.Set<T>().AsQueryable();
        }

    }
}
