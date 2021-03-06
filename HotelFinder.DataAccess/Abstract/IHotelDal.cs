using HotelFinder.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Abstract
{
    public interface IHotelDal
    {
        List<Hotel> GetHotels();
        Hotel GetHotelById(int id);
        Hotel Add(Hotel hotel);
        Hotel Update(Hotel hotel);
        void Delete(int id);

    }
}
