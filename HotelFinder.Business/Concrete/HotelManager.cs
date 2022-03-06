using HotelFinder.Business.Abstract;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Business.Concrete
{
    public class HotelManager : IHotelService
    {

        private IHotelDal _hotelDal;
        public HotelManager(IHotelDal hotelDal)
        {
            _hotelDal = hotelDal;
        }

        public Hotel Add(Hotel hotel)
        {
           return _hotelDal.Add(hotel);
            
        }

        public void Delete(int id)
        {
            _hotelDal.Delete(id);
        }

        public Hotel GetHotelById(int id)
        {
           return _hotelDal.GetHotelById(id);          
        }

        public List<Hotel> GetHotels()
        {
            return _hotelDal.GetHotels();
        }

        public Hotel Update(Hotel hotel)
        {
            return _hotelDal.Update(hotel);
        }
    }
}
