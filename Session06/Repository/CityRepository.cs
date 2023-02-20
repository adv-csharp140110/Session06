using Session06.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session06.Repository
{
    public class CityRepository
    {
        AppDbContext context;


        public CityRepository()
        {
            context= new AppDbContext();
        }
        
        public void Create(City model)
        {
            context.cities.Add(model);
            context.SaveChanges();
        }

        public void Update(City model)
        {
            context.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(City model)
        {
            context.cities.Remove(model);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var model = Find(id);
            context.cities.Remove(model);
            context.SaveChanges();
        }

        public City Find(int id) {
            return context.cities.Find(id);
        }


        public IQueryable<City> AsQueryable() {
            return context.cities.AsQueryable();
        }

    }
}
