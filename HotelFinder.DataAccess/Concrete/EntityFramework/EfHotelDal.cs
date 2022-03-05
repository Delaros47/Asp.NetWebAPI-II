using HotelFinder.DataAccess.Abstract;
using HotelFinder.DataAccess.Concrete.EntityFramework.Contexts;
using HotelFinder.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Concrete.EntityFramework
{
    public class EfHotelDal : IHotelDal
    {
        public Hotel Add(Hotel hotel)
        {
            using (var context = new HotelContext())
            {
                var addedEntity = context.Entry(hotel);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new HotelContext())
            {
                var deletedEntity = context.Entry(id);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Hotel GetHotelById(int id)
        {
            using (var context = new HotelContext())
            {
                return context.Hotels.SingleOrDefault(h => h.Id == id);
            }
        }

        public List<Hotel> GetHotels()
        {
            using (var context = new HotelContext())
            {
                return context.Hotels.ToList();
            }
        }

        public Hotel Update(Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}
