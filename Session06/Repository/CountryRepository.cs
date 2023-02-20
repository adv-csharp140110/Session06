using Session06.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session06.Repository
{
    public class CountryRepository
    {
        AppDbContext context;


        public CountryRepository()
        {
            context= new AppDbContext();
        }
        
        public void Create(Country model)
        {
            context.Countries.Add(model);
            context.SaveChanges();
        }

        public void Update(Country model)
        {
            context.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(Country model)
        {
            context.Countries.Remove(model);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var model = Find(id);
            context.Countries.Remove(model);
            context.SaveChanges();
        }

        public Country Find(int id) {
            return context.Countries.Find(id);
        }


        public IQueryable<Country> AsQueryable() {
            return context.Countries.AsQueryable();
        }

    }
}
